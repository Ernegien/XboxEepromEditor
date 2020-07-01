namespace XboxEepromEditor.Types
{
    /// <summary>
    /// Determines which encryption keys to use for the EEPROM's security section.
    /// </summary>
    public enum EepromVersion
    {
        /// <summary>
        /// Unknown version.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// Debug and Chihiro kernels.
        /// </summary>
        Debug,

        /// <summary>
        /// Version 1.0 kernels.
        /// </summary>
        RetailFirst,

        /// <summary>
        /// Version 1.1 through 1.4 kernels. Version 1.5 does not exist :)
        /// </summary>
        RetailMiddle,

        /// <summary>
        /// Version 1.6 kernels.
        /// </summary>
        RetailLast
    }
}
