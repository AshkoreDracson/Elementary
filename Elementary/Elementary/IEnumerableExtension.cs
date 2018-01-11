using System;
using System.Collections.Generic;
using System.Linq;
namespace Elementary
{
    public static class IEnumerableExtension
    {
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

        public static T Random<T>(this IEnumerable<T> o) => o.OrderBy(x => Mathf.Random()).FirstOrDefault();

        public static IEnumerable<T> Shuffle<T>(this T[] o)
        {
            List<int> avaliableIndexes = Enumerable.Range(0, o.Length).ToList();
            for (int i = 0; i < o.Length; i++)
            {
                int rndIndex = avaliableIndexes.Random();
                avaliableIndexes.Remove(rndIndex);

                yield return o[rndIndex];
            }
        }
        public static IEnumerable<T> Shuffle<T>(this T o) where T : List<T>
        {
            List<int> avaliableIndexes = Enumerable.Range(0, o.Count).ToList();
            for (int i = 0; i < o.Count; i++)
            {
                int rndIndex = avaliableIndexes.Random();
                avaliableIndexes.Remove(rndIndex);

                yield return o[rndIndex];
            }
        }
    }
}
