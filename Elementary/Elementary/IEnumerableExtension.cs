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
    }
}
