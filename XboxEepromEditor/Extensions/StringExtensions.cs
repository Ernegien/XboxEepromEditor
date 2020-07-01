using System;

namespace XboxEepromEditor.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a hexidecimal string to bytes.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static byte[] FromHexStringToBytes(this string str)
        {
            if (str.Length == 0 || str.Length % 2 != 0)
                throw new ArgumentException("Invalid hexidecimal string length");

            // TODO: replace with higher-performance version
            int count = str.Length / 2;
            byte[] bytes = new byte[count];
            for (int i = 0; i < count; i++)
            {
                bytes[i] = Convert.ToByte(str.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
    }
}
