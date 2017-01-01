using System;

namespace Elementary
{
    public static class Math
    {
        private static Random rnd;

        static Math()
        {
            rnd = new Random();
        }

        public static int Random()
        {
            return rnd.Next();
        }
        public static int Random(int max)
        {
            return rnd.Next(max);
        }
        public static int Random(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }
}
