using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace XboxEepromEditor.Extensions
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Converts an array of bytes to a hexidecimal string representation.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] data, int? offset = null, int? count = null)
        {
            int dataOffset = offset.GetValueOrDefault(0);
            int dataCount = count.GetValueOrDefault(data.Length - dataOffset);

            if (dataOffset < 0 || dataOffset >= data.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }

            if (dataCount <= 0 || dataOffset + dataCount > data.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            StringBuilder hexString = new StringBuilder();
            for (int i = 0; i < dataCount; i++)
            {
                hexString.Append(Convert.ToString(data[dataOffset + i], 16).ToUpperInvariant().PadLeft(2, '0'));
            }

            return hexString.ToString();
        }

        /// <summary>
        /// Fills the specified byte array with random data.
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Returns a reference of itself.</returns>
        public static byte[] FillRandom(this byte[] data)
        {
            NumericExtensions.Rng.NextBytes(data);
            return data;
        }

        /// <summary>
        /// Checks if the underlying data is equal.
        /// </summary>
        /// <param name="sourceData"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsEqual(this byte[] sourceData, byte[] data)
        {
            return StructuralComparisons.StructuralEqualityComparer.Equals(sourceData, data);
        }

        /// <summary>
        /// TODO: description
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pattern"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static int IndexOfArray(this byte[] data, byte[] pattern, int startIndex = 0)
        {
            for (int i = startIndex; i < data.Length; i++)
            {
                for (int j = 0; j < pattern.Length; j++)
                {
                    if (data[i + j] != pattern[j])
                        break;

                    if (j == pattern.Length - 1)
                        return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Returns a subset of data within the array at specified offset and of specified length.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static byte[] Subset(this byte[] data, int offset, int length)
        {
            return data.Skip(offset).Take(length).ToArray();
        }
    }
}
