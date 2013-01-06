using System;

namespace ColorMine.Utility
{
    public static class DoubleExtension
    {
        const double DefaultPrecision = .0001;
        internal static bool IsCloseTo(this double a, double b)
        {
            return a.IsCloseTo(b, DefaultPrecision);
        }

        internal static bool IsCloseTo(this double a, double b, double precision)
        {
            return Math.Abs(a - b) <= Math.Abs(a * precision);
        }
    }
}
