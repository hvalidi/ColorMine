using System;

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class LabConverter
    {
        // Observer= 2°, Illuminant= D65
        private const double RefX = 95.047;
        private const double RefY = 100.000;
        private const double RefZ = 108.883;

        internal static void ToColorSpace(IRgb color, ILab item)
        {
            var xyz = new Xyz();
            xyz.Initialize(color);

            var x = PivotXyz(xyz.X/RefX);
            var y = PivotXyz(xyz.Y/RefY);
            var z = PivotXyz(xyz.Z/RefZ);

            item.L = Math.Max(0,116*y - 16);
            item.A = 500*(x - y);
            item.B = 200*(y - z);
        }

        internal static IRgb ToColor(ILab item)
        {
            var y = (item.L + 16) / 116.0;
            var x = item.A / 500.0 + y;
            var z = y - item.B / 200.0;

            y = Math.Pow(y, 3) > 0.008856 ? Math.Pow(y, 3) : (y - 16/116)/7.787;
            x = Math.Pow(x, 3) > 0.008856 ? Math.Pow(x, 3) : (x - 16/116)/7.787;
            z = Math.Pow(z, 3) > 0.008856 ? Math.Pow(z, 3) : (z - 16/116)/7.787;

            var xyz = new Xyz
                {
                    X = RefX*x,
                    Y = RefY*y,
                    Z = RefZ*z
                };

            return xyz.ToRgb();
        }

        private static double PivotXyz(double n)
        {
            var i = CubicRoot(n);
            return n > 0.008856 ? i : 7.787*n + 16/116;
        }

        private static double CubicRoot(double n)
        {
            return Math.Pow(n, (1.0/3.0));
        }
    }
}