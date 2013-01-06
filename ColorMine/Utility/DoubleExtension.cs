using System;

namespace ColorMine.Utility
{
    public static class DoubleExtension
    {
        const double DefaultPrecision = .001;
        internal static bool BasicallyEqualTo(this double a, double b)
        {
            return a.BasicallyEqualTo(b, DefaultPrecision);
        }

        internal static bool BasicallyEqualTo(this double a, double b, double precision)
        {
            return Math.Abs(a - b) <= Math.Abs(a * precision);
        }
    }
}
