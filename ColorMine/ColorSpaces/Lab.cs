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

		    var x = PivotXyz(xyz.X / RefX);
		    var y = PivotXyz(xyz.Y / RefY);
		    var z = PivotXyz(xyz.Z / RefZ);

            L = 116*y - 16;
            A = 500*(x - y);
            B = 200*(y - z);
        }

        
        public override Color ToColor()
        {
            var y = (L + 16)/116;
            var x = A/500 + y;
            var z = y - B/200;

            y = Math.Pow(y, 3) > 0.008856 ? Math.Pow(y, 3) : (y - 16/116)/7.787;
            x = Math.Pow(x, 3) > 0.008856 ? Math.Pow(x, 3) : (x - 16/116)/7.787;
            z = Math.Pow(z, 3) > 0.008856 ? Math.Pow(z, 3) : (z - 16/116)/7.787;

            var xyz = new Xyz
                {
                    X = RefX*x,
                    Y = RefY*y,
                    Z = RefZ*z
                };

            return xyz.ToColor();
        }

        private static double PivotXyz(double n)
        {
            var i = CubicRoot(n);
            return n > 0.008856 ? i : 7.787 * n + 16 / 116;
        }

        private static double CubicRoot(double n)
        {
            return Math.Pow(n, (1.0 / 3.0));
        }
    }
}