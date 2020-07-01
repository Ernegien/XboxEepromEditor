using System;

namespace XboxEepromEditor.Types
{
    [Flags]
    public enum VideoSettings
    {
        Bit0 = 1 << 0,
        Bit1 = 1 << 1,
        Bit2 = 1 << 2,
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
        Widescreen = 1 << 16,       // 0x00010000
        Resolution720p = 1 << 17,   // 0x00020000 
        Resolution1080i = 1 << 18,  // 0x00040000
        Resolution480p = 1 << 19,   // 0x00080000
        Letterbox = 1 << 20,        // 0x00100000 
        Bit21 = 1 << 21,
        Bit22 = 1 << 22,
        Refresh60Hz = 1 << 23,      // 0x00400000 
        Refresh50Hz = 1 << 24,      // 0x00800000
        Bit25 = 1 << 25,
        Bit26 = 1 << 26,
        Bit27 = 1 << 27,
        Bit28 = 1 << 28,
        Bit29 = 1 << 29,
        Bit30 = 1 << 30,
        Bit31 = 1 << 31
    }
}
