using System;

namespace Elementary
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Checks if an <see cref="System.Array"/> contains a certain object.
        /// </summary>
        /// <param name="array">The Array</param>
        /// <param name="o">The object</param>
        /// <param name="absoluteEquals">Determines if the object must be absolutely equals to any item. If true, it will do the traditional equals checking, if false, it will use <see cref="object.Equals(object, object)"/> instead. Generally recommended to keep this false for string checking.</param>
        /// <returns>True if the <see cref="System.Array"/> contains the desired object, otherwise false</returns>
        public static bool Contains(this object[] array, object o, bool absoluteEquals = false)
        {
            if (absoluteEquals)
            {
                foreach (object item in array)
                {
                    if (item == o)
                        return true;
                }
                return false;
            }
            foreach (object item in array)
            {
                if (Equals(item, o))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if an <see cref="System.Array"/> contains a certain type.
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="t">The type</param>
        /// <returns>True if the <see cref="System.Array"/> contains the desired type, otherwise false</returns>
        public static bool ContainsType(this object[] array, Type t)
        {
            foreach (object item in array)
            {
                if (item.GetType() == t)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Checks if an <see cref="System.Array"/> contains a certain type.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>True if the <see cref="System.Array"/> contains the desired type, otherwise false</returns>
        public static bool ContainsType<T>(this object[] array)
        {
            foreach (object item in array)
            {
                if (item is T)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Returns a random item in the <see cref="System.Array"/>
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="array">The array</param>
        /// <returns>A random item fetched within the <see cref="System.Array"/></returns>
        public static T Random<T>(this T[] array) => array[Mathf.Random(array.Length)];
    }
}
