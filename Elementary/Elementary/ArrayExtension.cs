namespace Elementary
{
    public static class ArrayExtension
    {
        public static T Random<T>(this T[] array)
        {
            return array[Math.Random(array.Length)];
        }
    }
}
