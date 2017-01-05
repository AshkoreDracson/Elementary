using System;
using System.Linq;

namespace Elementary
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Checks if an array contains a certain type.
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="t">The type</param>
        /// <returns>True if the array contains the desired type, otherwise false</returns>
        public static bool ContainsType(this object[] array, Type t)
        {
            return array.Count(o => o.GetType() == t) > 0;
        }
        /// <summary>
        /// Checks if an array contains a certain type.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>True if the array contains the desired type, otherwise false</returns>
        public static bool ContainsType<T>(this object[] array)
        {
            return array.Count(o => o is T) > 0;
        }
        /// <summary>
        /// Returns a random item in the array
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>A random item fetched within the array</returns>
        public static T Random<T>(this T[] array)
        {
            return array[Math.Random(array.Length)];
        }
    }
}
