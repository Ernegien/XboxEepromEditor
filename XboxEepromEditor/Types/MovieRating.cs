namespace XboxEepromEditor.Types
{
    public enum MovieRating
    {
        /// <summary>
        /// Unknown rating.
        /// </summary>
        Unknown = -1,

        /// <summary>
        /// Not rated.
        /// </summary>
        NR = 0,

        /// <summary>
        /// Adults only.
        /// </summary>
        NC17 = 1,

        /// <summary>
        /// Restricted.
        /// </summary>
        R = 2,

        /// <summary>
        /// Parents strongly cautioned.
        /// </summary>
        PG13 = 4,

        /// <summary>
        /// Parental guidance suggested.
        /// </summary>
        PG = 5,

        /// <summary>
        /// General audiences.
        /// </summary>
        G = 7
    }
}
