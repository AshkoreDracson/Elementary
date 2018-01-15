using System;
using System.Collections.Generic;
using System.Linq;
namespace Elementary
{
    public static class IEnumerableExtension
    {
        /// <summary>
        /// Generates an <see cref="IEnumerable{T}"/> of <see cref="string"/> containing every possible char combination in the supplied string with a specified length
        /// </summary>
        /// <param name="s">The string</param>
        /// <param name="length">The length</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="string"/> containing every possible char combination in the supplied string with a specified length</returns>
        public static IEnumerable<string> Combinations(this string s, int length)
        {
            if (s == null || s.Length <= 0)
                throw new Exception("The specified string cannot be empty or null");

            if (length < 1)
                throw new Exception("The length cannot be inferior to 1");

            var q = s.Select(x => x.ToString());
            for (int i = 0; i < length - 1; i++)
                q = q.SelectMany(x => s, (x, y) => x + y);

            return q;
        }

        /// <summary>
        /// Picks a random element in this <see cref="IEnumerable{T}"/>
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="enumerable">The array</param>
        /// <returns>A random element in this <see cref="IEnumerable{T}"/></returns>
        public static T Random<T>(this IEnumerable<T> enumerable) => enumerable.OrderBy(x => Mathf.Random()).FirstOrDefault();

        /// <summary>
        /// Shuffles the supplied <see cref="System.Array"/>
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>A shuffled <see cref="IEnumerable{T}"/> of the supplied <see cref="System.Array"/></returns>
        public static IEnumerable<T> Shuffle<T>(this T[] array)
        {
            List<int> avaliableIndexes = Enumerable.Range(0, array.Length).ToList();
            for (int i = 0; i < array.Length; i++)
            {
                int rndIndex = avaliableIndexes.Random();
                avaliableIndexes.Remove(rndIndex);

                yield return array[rndIndex];
            }
        }
        /// <summary>
        /// Shuffles the supplied <see cref="List{T}"/>
        /// </summary>
        /// <typeparam name="T">The type</typeparam>s
        /// <param name="list">The list</param>
        /// <returns>A shuffled <see cref="IEnumerable{T}"/> of the supplied <see cref="List{T}"/></returns>
        public static IEnumerable<T> Shuffle<T>(this T list) where T : List<T>
        {
            List<int> avaliableIndexes = Enumerable.Range(0, list.Count).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                int rndIndex = avaliableIndexes.Random();
                avaliableIndexes.Remove(rndIndex);

                yield return list[rndIndex];
            }
        }
    }
}
