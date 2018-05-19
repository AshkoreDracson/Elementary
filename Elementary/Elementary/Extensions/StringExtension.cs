namespace Elementary
{
    public static class StringExtension
    {
        /// <summary>
        /// Trims the string to a certain length if it exceeds it
        /// </summary>
        /// <param name="s">The string</param>
        /// <param name="length">The length</param>
        /// <returns>The clamped string</returns>
        public static string Clamp(this string s, int length) => s.Length > length ? s.Substring(0, length) : s;
    }
}