namespace KyGunCo.Counterpoint.Sdk
{
    /// <summary>
    /// Custom logic and extensions to handle Counterpoint types.
    /// </summary>
    public static class CounterpointBool
    {
        /// <summary>
        /// Represents Counterpoint's T_BOOL:varchar(1) true value.
        /// </summary>
        public const string TrueString = "Y";

        /// <summary>
        /// Represents Counterpoint's T_BOOL:varchar(1) false value.
        /// </summary>
        public const string FalseString = "N";

        /// <summary>
        /// Extensions method to convert T_BOOL:varchar(1) string to native bool.
        /// </summary>
        /// <param name="value">String representation of T_BOOL:varchar(1).</param>
        /// <returns>Boolean value.</returns>
        public static bool ToBool(this string value) => value == TrueString;

        /// <summary>
        /// Extensions method to convert native bool to T_BOOL:varchar(1) string.
        /// </summary>
        /// <param name="value">Boolean value.</param>
        /// <returns>T_BOOL:varchar(1) string.</returns>
        public static string ToString(this bool value) => value ? TrueString : FalseString;
    }
}
