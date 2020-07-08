using System;

namespace XboxEepromEditor.Types
{
    /// <summary>
    /// NOTE: Values larger than 4 are not supported by XOnlineDash.
    /// </summary>
    [Flags]
    public enum Region
    {
        /// <summary>
        /// North American region.
        /// </summary>
        NorthAmerica = 1 << 0,

        /// <summary>
        /// Japan region.
        /// </summary>
        Japan = 1 << 1,

        /// <summary>
        /// Europe / Australia region.
        /// </summary>
        EuropeAustralia = 1 << 2,

        Bit3 = 1 << 3,
        Bit4 = 1 << 4,
        Bit5 = 1 << 5,
        Bit6 = 1 << 6,
        Bit7 = 1 << 7,
        Bit8 = 1 << 8,
        Bit9 = 1 << 9,
        Bit10 = 1 << 10,
        Bit11 = 1 << 11,
        Bit12 = 1 << 12,
        Bit13 = 1 << 13,
        Bit14 = 1 << 14,
        Bit15 = 1 << 15,
        Bit16 = 1 << 16,
        Bit17 = 1 << 17,
        Bit18 = 1 << 18,
        Bit19 = 1 << 19,
        Bit20 = 1 << 20,
        Bit21 = 1 << 21,
        Bit22 = 1 << 22,
        Bit23 = 1 << 23,
        Bit24 = 1 << 24,
        Bit25 = 1 << 25,
        Bit26 = 1 << 26,
        Bit27 = 1 << 27,
        Bit28 = 1 << 28,
        Bit29 = 1 << 29,
        Bit30 = 1 << 30,

        /// <summary>
        /// Debug/Chihiro have this set.
        /// </summary>
        Debug = 1 << 31
    }
}
