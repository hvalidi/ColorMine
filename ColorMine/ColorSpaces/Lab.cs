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
            // Observer= 2°, Illuminant= D65
            var ref_X = 95.047;
            var ref_Y = 100.000;
            var ref_Z = 108.883;

            var var_Y = (L + 16)/116;
            var var_X = A/500 + var_Y;
            var var_Z = var_Y - B/200;

            if (Math.Pow(var_Y, 3) > 0.008856)
                var_Y = Math.Pow(var_Y, 3);
            else
                var_Y = (var_Y - 16/116)/7.787;
            if (Math.Pow(var_X, 3) > 0.008856)
                var_X = Math.Pow(var_X, 3);
            else
                var_X = (var_X - 16/116)/7.787;
            if (Math.Pow(var_Z, 3) > 0.008856)
                var_Z = Math.Pow(var_Z, 3);
            else
                var_Z = (var_Z - 16/116)/7.787;

            var xyz = new Xyz
                {
                    X = ref_X*var_X,
                    Y = ref_Y*var_Y,
                    Z = ref_Z*var_Z
                };

            return xyz.ToColor();
        }

        private static double pivotXyz(double n)
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