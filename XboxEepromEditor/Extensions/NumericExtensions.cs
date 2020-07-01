using System;

namespace XboxEepromEditor.Extensions
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Random number generator.
        /// </summary>
        public static Random Rng = new Random();

        /// <summary>
        /// TODO: description
        /// </summary>
        /// <param name="value"></param>
        /// <param name="padWidth"></param>
        /// <returns></returns>
        public static string ToHexString(this long value, int padWidth = 0)
        {
            return "0x" + Convert.ToString(value, 16).PadLeft(padWidth, '0');
        }

        /// <summary>
        /// TODO: description
        /// </summary>
        /// <param name="value"></param>
        /// <param name="padWidth"></param>
        /// <returns></returns>
        public static string ToHexString(this int value, int padWidth = 0)
        {
            return ((long)value).ToHexString(padWidth);
        }

        /// <summary>
        /// Converts an Int32 into a Version.
        /// </summary>
        /// <param name="version"></param>
        /// <returns></returns>
        public static Version ToVersion(this int version)
        {
            return new Version(version & 0xFF, (version >> 8) & 0xFF,
                (version >> 16) & 0xFF, version >> 24);
        }
    }
}
