using System;
using XboxEepromEditor.Extensions;

namespace XboxEepromEditor
{
    public class Util
    {
        /// <summary>
        /// Rotates the value right by the specified number of bits.
        /// </summary>
        /// <param name="bits"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static uint RotateRight(int bits, uint value)
        {
            return ((value) << (bits)) | ((value) >> (32 - (bits)));
        }

        public static ulong GetRandomUInt64()
        {
            byte[] buffer = new byte[8];
            NumericExtensions.Rng.NextBytes(buffer);
            return BitConverter.ToUInt64(buffer, 0);
        }
    }
}
