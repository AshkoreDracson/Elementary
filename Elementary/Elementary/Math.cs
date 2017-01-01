using System;

namespace Elementary
{
    /*
    Some functions are simple wrapper methods from System.Math, this ensures that you won't shouldn't need the two libraries as this could cause annoyance at worst. 
    */

    public static class Math
    {
        private static Random rnd;

        public const double E = 2.7182818284590541;
        public const double PI = 3.1415926535897931;

        static Math()
        {
            rnd = new Random();
        }

        public static sbyte Abs(this sbyte value)
        {
            return (sbyte)(value >= 0 ? value : -value);
        }
        public static short Abs(this short value)
        {
            return (short)(value >= 0 ? value : -value);
        }
        public static int Abs(this int value)
        {
            return (value >= 0 ? value : -value);
        }
        public static long Abs(this long value)
        {
            return (value >= 0 ? value : -value);
        }
        public static float Abs(this float value)
        {
            return (value >= 0 ? value : -value);
        }
        public static double Abs(this double value)
        {
            return (value >= 0 ? value : -value);
        }
        public static decimal Abs(this decimal value)
        {
            return (value >= 0 ? value : -value);
        }

        public static float Acos(this float value)
        {
            return (float)System.Math.Acos(value);
        }
        public static double Acos(this double value)
        {
            return System.Math.Acos(value);
        }

        public static float Asin(this float value)
        {
            return (float)System.Math.Asin(value);
        }
        public static double Asin(this double value)
        {
            return System.Math.Asin(value);
        }

        public static float Atan(this float value)
        {
            return (float)System.Math.Atan(value);
        }
        public static double Atan(this double value)
        {
            return System.Math.Atan(value);
        }

        public static float Atan2(this float x, float y)
        {
            return (float)System.Math.Atan2(x, y);
        }
        public static double Atan2(this double x, double y)
        {
            return System.Math.Atan2(x, y);
        }

        public static long BigMul(this int a, int b)
        {
            return System.Math.BigMul(a, b);
        }

        public static float Ceiling(this float value)
        {
            return (float)System.Math.Ceiling(value);
        }
        public static double Ceiling(this double value)
        {
            return System.Math.Ceiling(value);
        }
        public static decimal Ceiling(this decimal value)
        {
            return System.Math.Ceiling(value);
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

        public static float Cos(this float value)
        {
            return (float)System.Math.Cos(value);
        }
        public static double Cos(this double value)
        {
            return System.Math.Cos(value);
        }

        public static float Cosh(this float value)
        {
            return (float)System.Math.Cosh(value);
        }
        public static double Cosh(this double value)
        {
            return System.Math.Cosh(value);
        }

        public static void DivRem(this int a, int b, out int result)
        {
            System.Math.DivRem(a, b, out result);
        }
        public static void DivRem(this long a, long b, out long result)
        {
            System.Math.DivRem(a, b, out result);
        }

        public static float Lerp(float from, float to, float t)
        {
            return from + (to - from) * t;
        }
        public static double Lerp(double from, double to, double t)
        {
            return from + (to - from) * t;
        }
        public static decimal Lerp(decimal from, decimal to, decimal t)
        {
            return from + (to - from) * t;
        }

        public static float InverseLerp(float from, float to, float value)
        {
            return (value - from) / (to - from);
        }
        public static double InverseLerp(double from, double to, double value)
        {
            return (value - from) / (to - from);
        }
        public static decimal InverseLerp(decimal from, decimal to, decimal value)
        {
            return (value - from) / (to - from);
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
        public static float Random(float min, float max)
        {
            return (float)(rnd.NextDouble().Remap(0.0f, 1.0f, min, max));
        }
        public static double Random(double min, double max)
        {
            return (rnd.NextDouble().Remap(0.0, 1.0, min, max));
        }
        // Decimal random isn't perfect, it bases off as a double so precision in the lower numbers is lost.
        public static decimal Random(decimal min, decimal max)
        {
            // Using Convert because recasting detects it as a double.
            return Convert.ToDecimal(rnd.NextDouble()).Remap(0m, 1m, min, max);
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

        public static sbyte Sign(this sbyte value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this short value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this int value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this long value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this float value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this double value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this decimal value)
        {
            if (value > 0)
                return 1;
            else if (value < 0)
                return -1;
            return 0;
        }
    }
}
