using System;
using System.Linq;

namespace Elementary
{
    public static class ArrayExtension
    {
        public static bool ContainsType(this object[] array, Type t)
        {
            return array.Count(o => o.GetType() == t) > 0;
        }
        public static bool ContainsType<T>(this object[] array)
        {
            return array.Count(o => o is T) > 0;
        }
        public static T Random<T>(this T[] array)
        {
            return array[Math.Random(array.Length)];
        }
    }
}
