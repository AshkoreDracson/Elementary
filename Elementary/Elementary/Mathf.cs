using System;

namespace Elementary
{
    /*
    Most functions are simple wrapper methods from System.Math, this ensures that you won't shouldn't need the two libraries as this could cause annoyance at worst. 
    */

    public static class Mathf
    {
        private static Random rnd;

        private static int _seed;
        /// <summary>
        /// The seed of the random number generator
        /// </summary>
        public static int Seed
        {
            get
            {
                return _seed;
            }
            set
            {
                _seed = value;
                rnd = new Random(value);
            }
        }

        /// <summary>
        /// e mathematical constant
        /// </summary>
        public const double E = 2.7182818284590541;
        /// <summary>
        /// π mathematical constant
        /// </summary>
        public const double PI = 3.1415926535897931;

        static Mathf()
        {
            _seed = (int)DateTime.Now.Ticks;
            rnd = new Random(_seed);
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
            return (value >= 0f ? value : -value);
        }
        public static double Abs(this double value)
        {
            return (value >= 0.0 ? value : -value);
        }
        public static decimal Abs(this decimal value)
        {
            return (value >= 0m ? value : -value);
        }

        public static float Acos(this float value)
        {
            return (float)Math.Acos(value);
        }
        public static double Acos(this double value)
        {
            return Math.Acos(value);
        }

        public static float Asin(this float value)
        {
            return (float)Math.Asin(value);
        }
        public static double Asin(this double value)
        {
            return Math.Asin(value);
        }

        public static float Atan(this float value)
        {
            return (float)Math.Atan(value);
        }
        public static double Atan(this double value)
        {
            return Math.Atan(value);
        }

        public static float Atan2(this float x, float y)
        {
            return (float)Math.Atan2(x, y);
        }
        public static double Atan2(this double x, double y)
        {
            return Math.Atan2(x, y);
        }

        public static long BigMul(this int a, int b)
        {
            return Math.BigMul(a, b);
        }

        public static float Ceiling(this float value)
        {
            return (float)Math.Ceiling(value);
        }
        public static double Ceiling(this double value)
        {
            return Math.Ceiling(value);
        }
        public static decimal Ceiling(this decimal value)
        {
            return Math.Ceiling(value);
        }

        public static int CeilingToInt(this float value)
        {
            return (int)Math.Ceiling(value);
        }
        public static int CeilingToInt(this double value)
        {
            return (int)Math.Ceiling(value);
        }
        public static int CeilingToInt(this decimal value)
        {
            return (int)Math.Ceiling(value);
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
            if (value < 0f)
                return 0f;
            else if (value > 1f)
                return 1f;
            return value;
        }
        public static double Clamp01(this double value)
        {
            if (value < 0.0)
                return 0.0;
            else if (value > 1.0)
                return 1.0;
            return value;
        }
        public static decimal Clamp01(this decimal value)
        {
            if (value < 0m)
                return 0m;
            else if (value > 1m)
                return 1m;
            return value;
        }

        public static sbyte ClampMin(this sbyte value, sbyte min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static short ClampMin(this short value, short min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static int ClampMin(this int value, int min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static long ClampMin(this long value, long min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static byte ClampMin(this byte value, byte min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static ushort ClampMin(this ushort value, ushort min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static uint ClampMin(this uint value, uint min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static ulong ClampMin(this ulong value, ulong min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static float ClampMin(this float value, float min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static double ClampMin(this double value, double min)
        {
            if (value < min)
                return min;
            return value;
        }
        public static decimal ClampMin(this decimal value, decimal min)
        {
            if (value < min)
                return min;
            return value;
        }

        public static sbyte ClampMax(this sbyte value, sbyte max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static short ClampMax(this short value, short max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static int ClampMax(this int value, int max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static long ClampMax(this long value, long max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static byte ClampMax(this byte value, byte max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static ushort ClampMax(this ushort value, ushort max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static uint ClampMax(this uint value, uint max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static ulong ClampMax(this ulong value, ulong max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static float ClampMax(this float value, float max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static double ClampMax(this double value, double max)
        {
            if (value > max)
                return max;
            return value;
        }
        public static decimal ClampMax(this decimal value, decimal max)
        {
            if (value > max)
                return max;
            return value;
        }

        public static float Cos(this float value)
        {
            return (float)Math.Cos(value);
        }
        public static double Cos(this double value)
        {
            return Math.Cos(value);
        }

        public static float Cosh(this float value)
        {
            return (float)Math.Cosh(value);
        }
        public static double Cosh(this double value)
        {
            return Math.Cosh(value);
        }

        public static void DivRem(this int a, int b, out int result)
        {
            Math.DivRem(a, b, out result);
        }
        public static void DivRem(this long a, long b, out long result)
        {
            Math.DivRem(a, b, out result);
        }

        public static float Exp(this float value)
        {
            return (float)Math.Exp(value);
        }
        public static double Exp(this double value)
        {
            return Math.Exp(value);
        }

        public static float Floor(this float value)
        {
            return (float)Math.Floor(value);
        }
        public static double Floor(this double value)
        {
            return Math.Floor(value);
        }
        public static decimal Floor(this decimal value)
        {
            return Math.Floor(value);
        }

        public static int FloorToInt(this float value)
        {
            return (int)Math.Floor(value);
        }
        public static int FloorToInt(this double value)
        {
            return (int)Math.Floor(value);
        }
        public static int FloorToInt(this decimal value)
        {
            return (int)Math.Floor(value);
        }

        public static float IEEERemainder(this float x, float y)
        {
            return (float)Math.IEEERemainder(x, y);
        }
        public static double IEEERemainder(this double x, double y)
        {
            return Math.IEEERemainder(x, y);
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

        public static float Log(this float value)
        {
            return (float)Math.Log(value);
        }
        public static float Log(this float value, float newBase)
        {
            return (float)Math.Log(value, newBase);
        }
        public static double Log(this double value)
        {
            return Math.Log(value);
        }
        public static double Log(this double value, double newBase)
        {
            return Math.Log(value, newBase);
        }

        public static float Log10(this float value)
        {
            return (float)Math.Log10(value);
        }
        public static double Log10(this double value)
        {
            return Math.Log10(value);
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

        public static sbyte Max(this sbyte a, sbyte b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static short Max(this short a, short b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static int Max(this int a, int b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static long Max(this long a, long b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static byte Max(this byte a, byte b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static ushort Max(this ushort a, ushort b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static uint Max(this uint a, uint b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static ulong Max(this ulong a, ulong b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static float Max(this float a, float b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static double Max(this double a, double b)
        {
            if (a < b)
                return b;
            return a;
        }
        public static decimal Max(this decimal a, decimal b)
        {
            if (a < b)
                return b;
            return a;
        }

        public static sbyte Min(this sbyte a, sbyte b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static short Min(this short a, short b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static int Min(this int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static long Min(this long a, long b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static byte Min(this byte a, byte b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static ushort Min(this ushort a, ushort b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static uint Min(this uint a, uint b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static ulong Min(this ulong a, ulong b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static float Min(this float a, float b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static double Min(this double a, double b)
        {
            if (a < b)
                return a;
            return b;
        }
        public static decimal Min(this decimal a, decimal b)
        {
            if (a < b)
                return a;
            return b;
        }

        public static float Pow(this float x, float y)
        {
            return (float)Math.Pow(x, y);
        }
        public static double Pow(this double x, double y)
        {
            return Math.Pow(x, y);
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
            return ((float)rnd.NextDouble()).Remap(0.0f, 1.0f, min, max);
        }
        public static double Random(double min, double max)
        {
            return rnd.NextDouble().Remap(0.0, 1.0, min, max);
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
            return outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);
        }
        public static double Remap(this double value, double inputMin, double inputMax, double outputMin, double outputMax)
        {
            return outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);
        }
        public static decimal Remap(this decimal value, decimal inputMin, decimal inputMax, decimal outputMin, decimal outputMax)
        {
            return outputMin + (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin);
        }

        public static float Round(this float value)
        {
            return (float)Math.Round(value);
        }
        public static float Round(this float value, int digits)
        {
            return (float)Math.Round(value, digits);
        }
        public static float Round(this float value, MidpointRounding mode)
        {
            return (float)Math.Round(value, (System.MidpointRounding)mode);
        }
        public static float Round(this float value, int digits, MidpointRounding mode)
        {
            return (float)Math.Round(value, digits, (System.MidpointRounding)mode);
        }
        public static double Round(this double value)
        {
            return Math.Round(value);
        }
        public static double Round(this double value, int digits)
        {
            return Math.Round(value, digits);
        }
        public static double Round(this double value, MidpointRounding mode)
        {
            return Math.Round(value, (System.MidpointRounding)mode);
        }
        public static double Round(this double value, int digits, MidpointRounding mode)
        {
            return Math.Round(value, digits, (System.MidpointRounding)mode);
        }
        public static decimal Round(this decimal value)
        {
            return Math.Round(value);
        }
        public static decimal Round(this decimal value, int digits)
        {
            return Math.Round(value, digits);
        }
        public static decimal Round(this decimal value, MidpointRounding mode)
        {
            return Math.Round(value, (System.MidpointRounding)mode);
        }
        public static decimal Round(this decimal value, int digits, MidpointRounding mode)
        {
            return Math.Round(value, digits, (System.MidpointRounding)mode);
        }

        public static int RoundToInt(this float value)
        {
            return (int)Math.Round(value);
        }
        public static int RoundToInt(this float value, MidpointRounding mode)
        {
            return (int)Math.Round(value, (System.MidpointRounding)mode);
        }
        public static int RoundToInt(this double value)
        {
            return (int)Math.Round(value);
        }
        public static int RoundToInt(this double value, MidpointRounding mode)
        {
            return (int)Math.Round(value, (System.MidpointRounding)mode);
        }
        public static int RoundToInt(this decimal value)
        {
            return (int)Math.Round(value);
        }
        public static int RoundToInt(this decimal value, MidpointRounding mode)
        {
            return (int)Math.Round(value, (System.MidpointRounding)mode);
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
            if (value > 0f)
                return 1;
            else if (value < 0f)
                return -1;
            return 0;
        }
        public static sbyte Sign(this double value)
        {
            if (value > 0.0)
                return 1;
            else if (value < 0.0)
                return -1;
            return 0;
        }
        public static sbyte Sign(this decimal value)
        {
            if (value > 0m)
                return 1;
            else if (value < 0m)
                return -1;
            return 0;
        }

        public static float Sin(this float value)
        {
            return (float)Math.Sin(value);
        }
        public static double Sin(this double value)
        {
            return Math.Sin(value);
        }

        public static float Sinh(this float value)
        {
            return (float)Math.Sinh(value);
        }
        public static double Sinh(this double value)
        {
            return Math.Sinh(value);
        }

        public static float Sqrt(this float value)
        {
            return (float)Math.Sqrt(value);
        }
        public static double Sqrt(this double value)
        {
            return Math.Sqrt(value);
        }

        public static float Tan(this float value)
        {
            return (float)Math.Tan(value);
        }
        public static double Tan(this double value)
        {
            return Math.Tan(value);
        }

        public static float Tanh(this float value)
        {
            return (float)Math.Tanh(value);
        }
        public static double Tanh(this double value)
        {
            return Math.Tanh(value);
        }

        public static float Truncate(this float value)
        {
            return (float)Math.Truncate(value);
        }
        public static double Truncate(this double value)
        {
            return Math.Truncate(value);
        }
        public static decimal Truncate(this decimal value)
        {
            return Math.Truncate(value);
        }
    }
}
