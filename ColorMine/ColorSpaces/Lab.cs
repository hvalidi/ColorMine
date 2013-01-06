using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    public class Lab : ColorSpace
    {
        public double L { get { return this[0]; } set { this[0] = value; } }
        public double A { get { return this[1]; } set { this[1] = value; } }
        public double B { get { return this[2]; } set { this[2] = value; } }

        // Observer= 2°, Illuminant= D65
        private const double RefX = 95.047;
        private const double RefY = 100.000;
        private const double RefZ = 108.883;

        public override void Initialize(Color color)
        {
            var xyz = new Xyz();
            xyz.Initialize(color);

		    var x = pivotXyz(xyz.X / RefX);
		    var y = pivotXyz(xyz.Y / RefY);
		    var z = pivotXyz(xyz.Z / RefZ);

            L = 116*y - 16;
            A = 500*(x - y);
            B = 200*(y - z);
        }

        public override Color ToColor()
        {
            var d65x = 0.9505;
            var d65y = 1.0;
            var d65z = 1.0890;
            var delta = 6.0f / 29.0;
            var fy = (L + 16f) / 116.0;
            var fx = fy + (A / 500.0f);
            var fz = fy - (B / 200.0f);
            var x = (fx > delta) ? d65x * (fx * fx * fx) : (fx - 16.0 / 116.0) * 3.0 * (delta * delta) * d65x;
            var y = (fy > delta) ? d65y * (fy * fy * fy) : (fy - 16.0 / 116.0) * 3.0 * (delta * delta) * d65y;
            var z = (fz > delta) ? d65z * (fz * fz * fz) : (fz - 16.0 / 116.0) * 3.0 * (delta * delta) * d65z;

            var r = x * 3.2410 - y * 1.5374 - z * 0.4986;
            var g = -x * 0.9692 + y * 1.8760 - z * 0.0416;
            var b = x * 0.0556 - y * 0.2040 + z * 1.0570;

            r = (r <= 0.0031308) ? 12.92 * r : (1.0 + 0.055) * Math.Pow(r, (1.0 / 2.4)) - 0.055;
            g = (g <= 0.0031308) ? 12.92 * g : (1.0 + 0.055) * Math.Pow(g, (1.0 / 2.4)) - 0.055;
            b = (b <= 0.0031308) ? 12.92 * b : (1.0 + 0.055) * Math.Pow(b, (1.0 / 2.4)) - 0.055;

            r = (r < 0) ? 0 : r;
            g = (g < 0) ? 0 : g;
            b = (b < 0) ? 0 : b;

            return Color.FromArgb(255, (int)r, (int)g, (int)b);
        }

        private static double pivotXyz(double n)
        {
            double i = CubicRoot(n);
            return n > 0.008856 ? i : 7.787 * n + 16 / 116;
        }

        private static double CubicRoot(double n)
        {
            return Math.Pow(n, (1.0 / 3.0));
        }
    }
}