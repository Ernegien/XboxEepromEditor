using System;

namespace XboxEepromEditor.Cryptography
{
    // RE'd from original retail Microsoft Xbox Kernel 4034 - eeprom section checksum pseudo-code (confirmed same functionality in latest 5838 kernel)

    // .text:80014816
    //int __stdcall get_eeprom_data(int offset, unsigned int length, char* result_ptr, char verify_checksum)
    //{
    //    int result; // eax

    //    if (!is_eeprom_read_and_cached)
    //    {
    //        result = read_eeprom();
    //        if (result < 0)
    //            return result;
    //        is_eeprom_read_and_cached = 1;
    //    }
    //    qmemcpy(result_ptr, (char*)&cached_eeprom + offset, length);
    //    if (verify_checksum && calculate_eeprom_checksum(result_ptr, length) != -1)
    //        result = 0xC000009C;  // STATUS_DEVICE_DATA_ERROR
    //    else
    //        result = 0;
    //    return result;
    //}

    // .text:80014799
    //int __stdcall calculate_eeprom_checksum(_DWORD *data, unsigned int size)
    //{
    //  _DWORD *v2; // ecx
    //  unsigned int v3; // eax
    //  unsigned int v4; // ebx
    //  unsigned int i; // edx

    //  v2 = data;
    //  v3 = 0;
    //  v4 = 0;
    //  for ( i = size >> 2; i; --i )
    //  {
    //    v4 = ((unsigned int)*v2 + __PAIR__(v4, v3)) >> 32;
    //    v3 += *v2;
    //    ++v2;
    //  }
    //  return __CFADD__(v4, v3) + v4 + v3;
    //}

    // .text:80014A90
    //signed int __stdcall ExSaveNonVolatileSetting(unsigned int a1, int a2, const void *a3, unsigned int a4)
    //{
    //...
    //v11 = ~calculate_eeprom_checksum(&v11, 96);  ; this is updating the user section checksum

    public static class Checksum
    {
        /// <summary>
        /// Calculates the EEPROM data checksum of specified offset and size.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static uint Calculate(byte[] data, int offset, int size)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (size % sizeof(uint) > 0)
                throw new ArgumentException("Size must be a multiple of four.", nameof(size));

            if (offset + size > data.Length)
                throw new ArgumentOutOfRangeException();

            // high and low parts of the internal checksum
            uint high = 0, low = 0;

            for (int i = 0; i < size / sizeof(uint); i++)
            {
                uint val = BitConverter.ToUInt32(data, offset + i * sizeof(uint));
                ulong sum = ((ulong)high << 32) | low;

                high = (uint)((sum + val) >> 32);
                low += val;
            }

            return high + low;
        }
    }
}
