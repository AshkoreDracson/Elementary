using System;
using System.Collections.Generic;

namespace Elementary
{
    public static class ListExtension
    {
        /// <summary>
        /// Checks if a list contains a certain type.
        /// </summary>
        /// <param name="list">The list</param>
        /// <param name="t">The type</param>
        /// <returns>True if the list contains the desired type, otherwise false</returns>
        public static bool ContainsType(this List<object> list, Type t)
        {
            foreach (object item in list)
            {
                if (item.GetType() == t)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if a list contains a certain type.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="list">The list</param>
        /// <returns>True if the list contains the desired type, otherwise false</returns>
        public static bool ContainsType<T>(this List<object> list)
        {
            foreach (object item in list)
            {
                if (item is T)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Returns a random item in the list
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="list">The list</param>
        /// <returns>A random item fetched within the list</returns>
        public static T Random<T>(this List<T> list)
        {
            return list[Math.Random(list.Count)];
        }
    }
}