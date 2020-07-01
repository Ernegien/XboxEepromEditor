//Copyright (C) 2003 [TEAM ASSEMBLY] www.team-assembly.com
//Copyright (C) 2020 Mike Davis

//This program is free software; you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation; either version 2 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License along
//with this program; if not, write to the Free Software Foundation, Inc.,
//51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.

using System;
using System.Diagnostics;
using XboxEepromEditor.Types;

namespace XboxEepromEditor.Cryptography
{
    public class HmacSha1
    {
        const int HashSize = 20;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly uint[] _intermediateHash = new uint[HashSize / sizeof(uint)];

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly byte[] _messageBlock = new byte[64];

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint _length = 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private uint _messageBlockIndex = 0;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private bool _isComputed = false;

        private void Reset(EepromVersion version, bool isFirst)
        {
            _messageBlockIndex = 0;
            _isComputed = false;
            _length = 512;

            switch (version)
            {
                case EepromVersion.Debug:
                    if (isFirst) FillIntermediateHash(0x85F9E51A, 0xE04613D2, 0x6D86A50C, 0x77C32E3C, 0x4BD717A4);
                    else FillIntermediateHash(0x5D7A9C6B, 0xE1922BEB, 0xB82CCDBC, 0x3137AB34, 0x486B52B3);
                    break;
                case EepromVersion.RetailFirst:
                    if (isFirst) FillIntermediateHash(0x72127625, 0x336472B9, 0xBE609BEA, 0xF55E226B, 0x99958DAC);
                    else FillIntermediateHash(0x76441D41, 0x4DE82659, 0x2E8EF85E, 0xB256FACA, 0xC4FE2DE8);
                    break;
                case EepromVersion.RetailMiddle:
                    if (isFirst) FillIntermediateHash(0x39B06E79, 0xC9BD25E8, 0xDBC6B498, 0x40B4389D, 0x86BBD7ED);
                    else FillIntermediateHash(0x9B49BED3, 0x84B430FC, 0x6B8749CD, 0xEBFE5FE5, 0xD96E7393);
                    break;
                case EepromVersion.RetailLast:
                    if (isFirst) FillIntermediateHash(0x8058763A, 0xF97D4E0E, 0x865A9762, 0x8A3D920D, 0x08995B2C);
                    else FillIntermediateHash(0x01075307, 0xA2f1E037, 0x1186EEEA, 0x88DA9992, 0x168A5609);
                    break;
                default:
                    throw new NotSupportedException("Invalid eeprom version.");
            }
        }
        
        private void Result(byte[] outputData, int offset)
        {
            if (!_isComputed)
            {
                Pad();
                _length = 0;
                _isComputed = true;
            }

            for (int i = 0; i < HashSize; ++i)
            {
                outputData[offset + i] = (byte)(_intermediateHash[i >> 2] >> 8 * (3 - (i & 3)));
            }
        }

        private void Pad()
        {
            if (_messageBlockIndex > 55)
            {
                _messageBlock[_messageBlockIndex++] = 0x80;
                while (_messageBlockIndex < 64)
                {
                    _messageBlock[_messageBlockIndex++] = 0;
                }

                ProcessMessageBlock();

                while (_messageBlockIndex < 56)
                {
                    _messageBlock[_messageBlockIndex++] = 0;
                }
            }
            else
            {
                _messageBlock[_messageBlockIndex++] = 0x80;
                while (_messageBlockIndex < 56)
                {
                    _messageBlock[_messageBlockIndex++] = 0;
                }
            }

            _messageBlock[56] = 0;
            _messageBlock[57] = 0;
            _messageBlock[58] = 0;
            _messageBlock[59] = 0;
            _messageBlock[60] = (byte)(_length >> 24);
            _messageBlock[61] = (byte)(_length >> 16);
            _messageBlock[62] = (byte)(_length >> 8);
            _messageBlock[63] = (byte)_length;

            ProcessMessageBlock();
        }

        private void Input(byte[] data, int offset, int length)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (offset + length > data.Length)
                throw new IndexOutOfRangeException();

            if (_isComputed)
                throw new InvalidOperationException("Result already computed.");

            while (length-- > 0)
            {
                _messageBlock[_messageBlockIndex++] = data[offset++];
                _length += 8;

                if (_messageBlockIndex == 64)
                {
                    ProcessMessageBlock();
                }
            }
        }

        private void ProcessMessageBlock()
        {
            uint[] k = new uint[] { 0x5A827999, 0x6ED9EBA1, 0x8F1BBCDC, 0xCA62C1D6 };
            uint[] w = new uint[80];
            uint a = _intermediateHash[0];
            uint b = _intermediateHash[1];
            uint c = _intermediateHash[2];
            uint d = _intermediateHash[3];
            uint e = _intermediateHash[4];

            for (int i = 0; i < 16; i++)
            {
                w[i] = (uint)(_messageBlock[i * sizeof(uint)] << 24);
                w[i] |= (uint)(_messageBlock[i * sizeof(uint) + 1] << 16);
                w[i] |= (uint)(_messageBlock[i * sizeof(uint) + 2] << 8);
                w[i] |= _messageBlock[i * sizeof(uint) + 3];
            }

            for (int i = 16; i < 80; i++)
            {
                w[i] = Util.RotateRight(1, w[i - 3] ^ w[i - 8] ^ w[i - 14] ^ w[i - 16]);
            }

            for (int i = 0; i < 80; i++)
            {
                uint temp = Util.RotateRight(5, a);
                switch (i / 20)
                {
                    case 0: temp += ((b & c) | ((~b) & d)) + e + w[i] + k[0]; break;
                    case 1: temp += (b ^ c ^ d) + e + w[i] + k[1]; break;
                    case 2: temp += ((b & c) | (b & d) | (c & d)) + e + w[i] + k[2]; break;
                    case 3: temp += (b ^ c ^ d) + e + w[i] + k[3]; break;
                }
                
                e = d;
                d = c;
                c = Util.RotateRight(30, b);
                b = a;
                a = temp;
            }
            
            _intermediateHash[0] += a;
            _intermediateHash[1] += b;
            _intermediateHash[2] += c;
            _intermediateHash[3] += d;
            _intermediateHash[4] += e;
            _messageBlockIndex = 0;
        }

        private void FillIntermediateHash(uint a, uint b, uint c, uint d, uint e)
        {
            _intermediateHash[0] = a;
            _intermediateHash[1] = b;
            _intermediateHash[2] = c;
            _intermediateHash[3] = d;
            _intermediateHash[4] = e;
        }

        public byte[] Compute(EepromVersion version, byte[] data)
        {
            if (data.Length >= uint.MaxValue / 8 - 512)
                throw new NotSupportedException("Too large of an input.");

            byte[] result = new byte[HashSize];

            Reset(version, true);
            Input(data, 0, data.Length);
            Result(_messageBlock, 0);
            Reset(version, false);
            Input(_messageBlock, 0, HashSize);
            Result(result, 0);

            return result;
        }
    }
}
