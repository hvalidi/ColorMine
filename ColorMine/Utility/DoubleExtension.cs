using System;

namespace ColorMine.Utility
{
    public static class DoubleExtension
    {
        private const double DefaultPrecision = .0001;

        internal static bool BasicallyEqualTo(this double a, double b)
        {
            return a.BasicallyEqualTo(b, DefaultPrecision);
        }

        internal static bool BasicallyEqualTo(this double a, double b, double precision)
        {
            return Math.Abs(a - b) <= precision;
        }
    }
}