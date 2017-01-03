using System;
using System.Collections.Generic;
using System.Linq;

namespace Elementary
{
    public static class ListExtension
    {
        public static bool ContainsType(this List<object> list, Type t)
        {
            return list.Count(o => o.GetType() == t) > 0;
        }
        public static bool ContainsType<T>(this List<object> list)
        {
            return list.Count(o => o is T) > 0;
        }
        public static T Random<T>(this List<T> list)
        {
            return list[Math.Random(list.Count)];
        }
    }
}