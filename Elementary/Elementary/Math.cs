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

        public static sbyte Clamp(this sbyte value, sbyte min, sbyte max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static short Clamp(this short value, short min, short max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static int Clamp(this int value, int min, int max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static long Clamp(this long value, long min, long max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static byte Clamp(this byte value, byte min, byte max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static ushort Clamp(this ushort value, ushort min, ushort max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static uint Clamp(this uint value, uint min, uint max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static ulong Clamp(this ulong value, ulong min, ulong max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static float Clamp(this float value, float min, float max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static double Clamp(this double value, double min, double max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }
        public static decimal Clamp(this decimal value, decimal min, decimal max)
        {
            if (value < min)
                return min;
            else if (value > max)
                return max;
            return value;
        }

        public static sbyte Clamp01(this sbyte value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static short Clamp01(this short value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static int Clamp01(this int value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static long Clamp01(this long value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static byte Clamp01(this byte value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static ushort Clamp01(this ushort value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static uint Clamp01(this uint value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static ulong Clamp01(this ulong value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static float Clamp01(this float value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static double Clamp01(this double value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }
        public static decimal Clamp01(this decimal value)
        {
            if (value < 0)
                return 0;
            else if (value > 1)
                return 1;
            return value;
        }

        public static float Lerp(float a, float b, float t)
        {
            return a + (b - a) * t;
        }
        public static double Lerp(double a, double b, double t)
        {
            return a + (b - a) * t;
        }
        public static decimal Lerp(decimal a, decimal b, decimal t)
        {
            return a + (b - a) * t;
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

        public static float RandomFloat()
        {
            return (float)rnd.NextDouble();
        }
        public static double RandomDouble()
        {
            return rnd.NextDouble();
        }

        public static float Remap(this float value, float inputMin, float inputMax, float outputMin, float outputMax)
        {
            return (value - inputMin) / (outputMin - inputMin) * (outputMax - inputMax) + inputMax;
        }
        public static double Remap(this double value, double inputMin, double inputMax, double outputMin, double outputMax)
        {
            return (value - inputMin) / (outputMin - inputMin) * (outputMax - inputMax) + inputMax;
        }
        public static decimal Remap(this decimal value, decimal inputMin, decimal inputMax, decimal outputMin, decimal outputMax)
        {
            return (value - inputMin) / (outputMin - inputMin) * (outputMax - inputMax) + inputMax;
        }
    }
}
