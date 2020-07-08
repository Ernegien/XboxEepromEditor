using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using XboxEepromEditor.Cryptography;
using XboxEepromEditor.Extensions;
using XboxEepromEditor.Types;

namespace XboxEepromEditor
{
    public class Eeprom
    {
        public static int Size = 256;

        public byte[] Data { get; private set; }
        private Stream Stream { get; set; }
        private BinaryReader Reader { get; set; }
        private BinaryWriter Writer { get; set; }

        public EepromVersion Version { get; set; } = EepromVersion.Unknown;

        #region Security Section

        /// <summary>
        /// The HMAC SHA1 hash of the RC4-decrypted confounder, hdd key, and region data.
        /// </summary>
        /// <remarks>20-byte value at offset 0x0</remarks>
        public byte[] SecurityHash
        {
            get
            {
                return Data.Subset(0, 20);
            }
            private set // this shouldn't be set directly by the user
            {
                if (value.Length != SecurityHash.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The RC4-decrypted HMAC confounder.
        /// </summary>
        /// <remarks>8-byte value at offset 0x14</remarks>
        public byte[] Confounder
        {
            get
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                return Data.Subset(0x14, 8);
            }
            set
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                if (value.Length != Confounder.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x14;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The RC4-decrypted key used for locking/unlocking the HDD.
        /// </summary>
        /// <remarks>16-byte value at offset 0x1C</remarks>
        public byte[] HddKey
        {
            get
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                return Data.Subset(0x1C, 16);
            }
            set
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                if (value.Length != HddKey.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x1C;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The RC4-decrypted game region.
        /// </summary>
        /// <remarks>4-byte value at offset 0x2C</remarks>
        public Region Region
        {
            get
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                return (Region)BitConverter.ToInt32(Data, 0x2C);
            }
            set
            {
                if (Version == EepromVersion.Unknown)
                    throw new NotSupportedException("Unknown EEPROM version.");

                Stream.Position = 0x2C;
                Writer.Write((int)value);
            }
        }

        #endregion

        #region Factory Section

        /// <summary>
        /// The factory settings section data (offset range 0x34 to 0x60) checksum.
        /// </summary>
        /// <remarks>4-byte value at offset 0x30</remarks>
        public uint FactorySectionChecksum
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x30);
            }
            private set // this shouldn't be set directly by the user
            {
                Stream.Position = 0x30;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The factory-assigned serial number.
        /// </summary>
        /// <remarks>12-character numerical ASCII value at offset 0x34</remarks>
        public string Serial
        {
            get
            {
                return Encoding.ASCII.GetString(Data, 0x34, 12);
            }
            set
            {
                // this probably isn't true, but would likely invalidate a bunch of assumptions by 3rd party stuff
                if (!Regex.IsMatch(value, "\\d{12}"))
                    throw new InvalidDataException("Serial must be a 12-character numerical value.");

                Stream.Position = 0x34;
                Writer.Write(Encoding.ASCII.GetBytes(value));
            }
        }

        /// <summary>
        /// The ethernet MAC address.
        /// </summary>
        /// <remarks>6-byte value at offset 0x40</remarks>
        public byte[] MacAddress
        {
            get
            {
                return Data.Subset(0x40, 6);
            }
            set
            {
                Stream.Position = 0x40;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// Unknown padding.
        /// </summary>
        /// <remarks>2-byte value at offset 0x46</remarks>
        public ushort UnknownPadding
        {
            get
            {
                return BitConverter.ToUInt16(Data, 0x46);
            }
            set
            {
                Stream.Position = 0x46;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The online key.
        /// </summary>
        /// <remarks>16-byte value at offset 0x48</remarks>
        public byte[] OnlineKey
        {
            get
            {
                return Data.Subset(0x48, 16);
            }
            set
            {
                Stream.Position = 0x48;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The video standard.
        /// </summary>
        /// <remarks>4-byte value at offset 0x58</remarks>
        public VideoStandard VideoStandard
        {
            get
            {
                return (VideoStandard)BitConverter.ToUInt32(Data, 0x58);
            }
            set
            {
                Stream.Position = 0x58;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// Unknown padding.
        /// </summary>
        /// <remarks>4-byte value at offset 0x5C</remarks>
        public uint UnknownPadding2
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x5C);
            }
            set
            {
                Stream.Position = 0x5C;
                Writer.Write(value);
            }
        }

        #endregion

        #region User Section

        /// <summary>
        /// The user settings section data (offset range 0x64 to 0xC0) checksum.
        /// </summary>
        /// <remarks>4-byte value at offset 0x60</remarks>
        public uint UserSectionChecksum
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x60);
            }
            private set // this shouldn't be set directly by the user
            {
                Stream.Position = 0x60;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The time zone negative offset in minutes relative to GMT.
        /// </summary>
        /// <remarks>4-byte value at offset 0x64</remarks>
        public uint ZoneBias
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x64);
            }
            set
            {
                Stream.Position = 0x64;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The standard timezone name.
        /// </summary>
        /// <remarks>4-byte value at offset 0x68</remarks>
        public string StandardTimezone
        {
            get
            {
                return Encoding.ASCII.GetString(Data, 0x68, 4);
            }
            set
            {
                if (value.Length != StandardTimezone.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x68;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The daylight savings timezone name.
        /// </summary>
        /// <remarks>4-byte value at offset 0x6C</remarks>
        public string DaylightTimezone
        {
            get
            {
                return Encoding.ASCII.GetString(Data, 0x6C, 4);
            }
            set
            {
                if (value.Length != DaylightTimezone.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x6C;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// Unknown padding.
        /// </summary>
        /// <remarks>8-byte value at offset 0x70</remarks>
        public byte[] UnknownPadding3
        {
            get
            {
                return Data.Subset(0x70, 8);
            }
            set
            {
                if (value.Length != UnknownPadding3.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x70;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// Specifies when the standard time starts in the format of Month-Day-DayOfWeek-Hour (10-05-00-02).
        /// </summary>
        /// <remarks>4-byte value at offset 0x78</remarks>
        public uint StandardTimeStarts
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x78);
            }
            set
            {
                Stream.Position = 0x78;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// Specifies when the daylight savings time starts in the format of Month-Day-DayOfWeek-Hour (04-01-00-02).
        /// </summary>
        /// <remarks>4-byte value at offset 0x7C</remarks>
        public uint DaylightTimeStarts
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x7C);
            }
            set
            {
                Stream.Position = 0x7C;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// Unknown padding.
        /// </summary>
        /// <remarks>8-byte value at offset 0x80</remarks>
        public byte[] UnknownPadding4
        {
            get
            {
                return Data.Subset(0x80, 8);
            }
            set
            {
                if (value.Length != UnknownPadding4.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0x80;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The standard time zone bias in minutes.
        /// </summary>
        /// <remarks>4-byte value at offset 0x88</remarks>
        public int StandardTimeBias
        {
            get
            {
                return BitConverter.ToInt32(Data, 0x88);
            }
            set
            {
                Stream.Position = 0x88;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The daylight savings time zone bias in minutes.
        /// </summary>
        /// <remarks>4-byte value at offset 0x8C</remarks>
        public int DaylightTimeBias
        {
            get
            {
                return BitConverter.ToInt32(Data, 0x8C);
            }
            set
            {
                Stream.Position = 0x8C;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The language.
        /// </summary>
        /// <remarks>4-byte value at offset 0x90</remarks>
        public Language Language
        {
            get
            {
                return (Language)BitConverter.ToUInt32(Data, 0x90);
            }
            set
            {
                Stream.Position = 0x90;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The video setting flags.
        /// </summary>
        /// <remarks>4-byte value at offset 0x94</remarks>
        public VideoSettings VideoSettings
        {
            get
            {
                return (VideoSettings)BitConverter.ToUInt32(Data, 0x94);
            }
            set
            {
                Stream.Position = 0x94;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The audio setting flags.
        /// </summary>
        /// <remarks>4-byte value at offset 0x98</remarks>
        public AudioSettings AudioSettings
        {
            get
            {
                return (AudioSettings)BitConverter.ToUInt32(Data, 0x98);
            }
            set
            {
                Stream.Position = 0x98;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The parental control max game rating that can be played.
        /// </summary>
        /// <remarks>4-byte value at offset 0x9C</remarks>
        public GameRating ParentalControlGameRating
        {
            get
            {
                return (GameRating)BitConverter.ToUInt32(Data, 0x9C);
            }
            set
            {
                Stream.Position = 0x9C;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The parental control 4-button passcode.
        /// A passcode of 0x00001423 is D-pad directions up (0x1), right (0x4), down (0x2), and left (0x3).
        /// </summary>
        /// <remarks>4-byte value at offset 0xA0</remarks>
        public uint ParentalControlPasscode
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0xA0);
            }
            set
            {
                Stream.Position = 0xA0;
                Writer.Write(value);
            }
        }

        /// <summary>
        /// The parental control max movie rating that can be played.
        /// </summary>
        /// <remarks>4-byte value at offset 0xA4</remarks>
        public MovieRating ParentalControlMovieRating
        {
            get
            {
                return (MovieRating)BitConverter.ToUInt32(Data, 0xA4);
            }
            set
            {
                Stream.Position = 0xA4;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The Xbox Live IP address.
        /// </summary>
        /// <remarks>4-byte value at offset 0xA8</remarks>
        public IPAddress LiveAddress
        {
            get
            {
                return new IPAddress(BitConverter.ToUInt32(Data, 0xA8));
            }
            set
            {
                Stream.Position = 0xA8;
                #pragma warning disable CS0618 // Type or member is obsolete
                Writer.Write((uint)value.Address);
                #pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        /// <summary>
        /// The Xbox Live DNS server IP address.
        /// </summary>
        /// <remarks>4-byte value at offset 0xAC</remarks>
        public IPAddress LiveDns
        {
            get
            {
                return new IPAddress(BitConverter.ToUInt32(Data, 0xAC));
            }
            set
            {
                Stream.Position = 0xAC;
                #pragma warning disable CS0618 // Type or member is obsolete
                Writer.Write((uint)value.Address);
                #pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        /// <summary>
        /// The Xbox Live gateway IP address.
        /// </summary>
        /// <remarks>4-byte value at offset 0xB0</remarks>
        public IPAddress LiveGateway
        {
            get
            {
                return new IPAddress(BitConverter.ToUInt32(Data, 0xB0));
            }
            set
            {
                Stream.Position = 0xB0;
                #pragma warning disable CS0618 // Type or member is obsolete
                Writer.Write((uint)value.Address);
                #pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        /// <summary>
        /// The Xbox Live subnet mask.
        /// </summary>
        /// <remarks>4-byte value at offset 0xB4</remarks>
        public IPAddress LiveSubnet
        {
            get
            {
                return new IPAddress(BitConverter.ToUInt32(Data, 0xB4));
            }
            set
            {
                Stream.Position = 0xB4;
                #pragma warning disable CS0618 // Type or member is obsolete
                Writer.Write((uint)value.Address);
                #pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        /// <summary>
        /// Example values: 0x4, 0x8, 0x9, 0xA, 0xC, 0xF
        /// </summary>
        /// <remarks>4-byte value at offset 0xB8</remarks>
        public UnknownFlags UnknownFlagsB8
        {
            get
            {
                return (UnknownFlags)BitConverter.ToUInt32(Data, 0xB8);
            }
            set
            {
                Stream.Position = 0xB8;
                Writer.Write((uint)value);
            }
        }

        /// <summary>
        /// The dvd playback zone.
        /// </summary>
        /// <remarks>4-byte value at offset 0xBC</remarks>
        public DvdPlaybackZone DvdPlaybackZone
        {
            get
            {
                return (DvdPlaybackZone)BitConverter.ToUInt32(Data, 0xBC);
            }
            set
            {
                Stream.Position = 0xBC;
                Writer.Write((uint)value);
            }
        }

        #endregion

        #region Misc Section

        /// <summary>
        /// Unknown codes/history/reburb info. Only seems to be used by 1.6 boxes?
        /// </summary>
        public byte[] MiscData
        {
            get
            {
                return Data.Subset(0xC0, 52);
            }
            set
            {
                if (value.Length != MiscData.Length)
                    throw new ArgumentException("Invalid length.");

                Stream.Position = 0xC0;
                Writer.Write(value);
            }
        }

        public uint UnknownValueF4
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0xF4);
            }
            set
            {
                Stream.Position = 0xF4;
                Writer.Write(value);
            }
        }

        public UnknownFlags UnknownFlagsF8
        {
            get
            {
                return (UnknownFlags)BitConverter.ToUInt32(Data, 0xF8);
            }
            set
            {
                Stream.Position = 0xF8;
                Writer.Write((uint)value);
            }
        }

        public UnknownFlags UnknownFlagsFC
        {
            get
            {
                return (UnknownFlags)BitConverter.ToUInt32(Data, 0xFC);
            }
            set
            {
                Stream.Position = 0xFC;
                Writer.Write((uint)value);
            }
        }

        #endregion

        /// <summary>
        /// Initialize a default EEPROM of specified version.
        /// </summary>
        /// <param name="version"></param>
        public Eeprom(EepromVersion version = EepromVersion.RetailFirst)
        {
            Data = new byte[Size];
            Stream = new MemoryStream(Data);
            Reader = new BinaryReader(Stream);
            Writer = new BinaryWriter(Stream);

            // defaults
            Version = version;
            Region = Region.NorthAmerica;
            VideoStandard = VideoStandard.NtscM;
            Language = Language.English;

            // randomly generate new keys and hardware info
            Serial = GeneratRandomSerial();
            Confounder = new byte[8].FillRandom();
            HddKey = new byte[16].FillRandom();
            OnlineKey = new byte[16].FillRandom();
            MacAddress = GenerateRandomMac();
        }

        public Eeprom(string file)
        {
            Data = File.ReadAllBytes(file);

            if (Data.Length != Size)
                throw new InvalidDataException("EEPROM must be 256 bytes.");

            Stream = new MemoryStream(Data);
            Reader = new BinaryReader(Stream);
            Writer = new BinaryWriter(Stream);

            HmacSha1 sha = new HmacSha1();
            RC4 rc4 = new RC4();
            EepromVersion version = 0;

            // loop through each version attempting to decrypt the security data
            while (version <= EepromVersion.RetailLast)
            {
                byte[] origHash = Data.Subset(0, 20);

                // decrypt according to the specified version
                rc4.Init(sha.Compute(version, origHash));
                byte[] decrypted = Data.Subset(0x14, 0x1C);
                rc4.Crypt(decrypted, 0, decrypted.Length);

                // if decrypted data hash matches the original then it's valid and the specific version is now known
                if (origHash.IsEqual(sha.Compute(version, decrypted)))
                {
                    // update with the decrypted data
                    Stream.Position = 0x14;
                    Writer.Write(decrypted);

                    // set the detected version
                    Version = version;
                    break;
                }

                version++;
            }
        }

        /// <summary>
        /// Saves the eeprom contents to file.
        /// If the version is unknown the security section will not be overwritten.
        /// </summary>
        /// <param name="file"></param>
        public void Save(string file)
        {
            UpdateChecksums();

            // skip writing security section if version is unknown
            if (Version == EepromVersion.Unknown)
            {
                using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Write, FileShare.None))
                {
                    fs.Position = 0x30;
                    fs.Write(Data, 0x30, Size - 0x30);
                }
            }
            else
            {
                // copy data to a separate buffer
                byte[] eepromCopy = new byte[Size];
                Data.CopyTo(eepromCopy, 0);

                // update security section of copy
                if (Version != EepromVersion.Unknown)
                {
                    HmacSha1 sha = new HmacSha1();
                    RC4 rc4 = new RC4();

                    // hash decrypted confounder/hddkey/region
                    byte[] hash = sha.Compute(Version, eepromCopy.Subset(0x14, 0x1C));
                    hash.CopyTo(eepromCopy, 0);

                    // re-encrypt data
                    rc4.Init(sha.Compute(Version, hash));
                    rc4.Crypt(eepromCopy, 20, 28);
                }

                File.WriteAllBytes(file, eepromCopy);
            }
        }

        /// <summary>
        /// Updates the factory and user section checksums.
        /// </summary>
        public void UpdateChecksums()
        {
            // update factory section checksum
            FactorySectionChecksum = ~Checksum.Calculate(Data, 0x34, 0x2C);
            if (Checksum.Calculate(Data, 0x30, 0x30) != 0xFFFFFFFF)
            {
                throw new InvalidDataException("This shouldn't happen, and the checksum algorithm must be wrong.");
            }
            
            // update user section checksum
            UserSectionChecksum = ~Checksum.Calculate(Data, 0x64, 0x5C);
            if (Checksum.Calculate(Data, 0x60, 0x60) != 0xFFFFFFFF)
            {
                throw new InvalidDataException("This shouldn't happen, and the checksum algorithm must be wrong.");
            }
        }

        /// <summary>
        /// Generates a random numerical serial number with "9" being the last number for identification purposes.
        /// </summary>
        /// <returns></returns>
        private string GeneratRandomSerial()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 11; i++)
            {
                sb.Append(NumericExtensions.Rng.Next(0, 10));
            }
            return sb.ToString() + "9";
        }

        /// <summary>
        /// Generates a random Xbox-specific MAC address.
        /// </summary>
        /// <returns></returns>
        private byte[] GenerateRandomMac()
        {
            // valid microsoft prefixes
            List<byte[]> prefixes = new List<byte[]>
            {
                new byte[] { 0x00, 0x50, 0xF2 },    // 1.0+
                new byte[] { 0x00, 0x0D, 0x3A },    // 1.1+
                new byte[] { 0x00, 0x12, 0x5A }     // 1.6
                // TODO: probably other Xbox-specific ones, and plenty of other generic Microsoft ones that could possibly be added without issue
            };

            var mac = new byte[6].FillRandom();
            prefixes[NumericExtensions.Rng.Next(0, prefixes.Count)].CopyTo(mac, 0);
            return mac;
        }

        // TODO: helper function for time settings based on time zone string - "America/Chicago" etc.
    }
}
