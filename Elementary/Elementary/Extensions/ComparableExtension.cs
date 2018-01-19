using System;

namespace Elementary
{
    public static class ComparableExtension
    {
        /// <summary>
        /// Determines whetever <see cref="value"/> is in range (inclusive) between <see cref="min"/> and <see cref="max"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value</param>
        /// <param name="min">The minimum value of the range</param>
        /// <param name="max">The maximum value of the range</param>
        /// <returns>Whetever <see cref="value"/> is in range (inclusive) between <see cref="min"/> and <see cref="max"/></returns>
        public static bool InRange<T>(this T value, T min, T max) where T : IComparable<T> => min.CompareTo(value) <= 0 && value.CompareTo(max) <= 0;
        /// <summary>
        /// Determines whetever <see cref="value"/> is in range (exclusive) between <see cref="min"/> and <see cref="max"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value</param>
        /// <param name="min">The minimum value of the range</param>
        /// <param name="max">The maximum value of the range</param>
        /// <returns>Whetever <see cref="value"/> is in range (exclusive) between <see cref="min"/> and <see cref="max"/></returns>
        public static bool InRangeExclusive<T>(this T value, T min, T max) where T : IComparable<T> => min.CompareTo(value) < 0 && value.CompareTo(max) < 0;
    }
}