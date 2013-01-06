using System;
using System.Drawing;
using System.Linq;
using ColorMine.Utility;

namespace ColorMine.ColorSpaces
{
    internal class Hsl : ColorSpace
    {
        public double H { get { return this[0]; } set { this[0] = value; } }
        public double S { get { return this[1]; } set { this[1] = value; } }
        public double L { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            var r = (color.R / 255.0);
            var g = (color.G / 255.0);
            var b = (color.B / 255.0);

            var min = Min(r, g, b); // Min. value of RGB
            var max = Max(r, g, b); // Max. value of RGB
            var deltaMax = max - min; // Delta RGB value

            var l = (max + min) / 2;
            var h = 0.0;
            var s = 0.0;

            if (deltaMax != 0.0)
            {
                s = (l < 0.5) ? deltaMax / (max + min) : deltaMax / (2.0 - max - min);

                double deltaR = (((max - r) / 6.0) + (deltaMax / 2.0)) / deltaMax;
                double deltaG = (((max - g) / 6.0) + (deltaMax / 2.0)) / deltaMax;
                double deltaB = (((max - b) / 6.0) + (deltaMax / 2.0)) / deltaMax;

                if (r.BasicallyEqualTo(max))
                {
                    h = deltaB - deltaG;
                }
                else if (g.BasicallyEqualTo(max))
                {
                    h = (1.0 / 3.0) + deltaR - deltaB;
                }
                else if (b.BasicallyEqualTo(max))
                {
                    h = (2.0 / 3.0) + deltaG - deltaR;
                }

                if (h < 0.0)
                {
                    h += 1.0;
                }
                else if (h > 1.0)
                {
                    h -= 1.0;
                }

            }

            H = h;
            S = s;
            L = l;
        }

        public override Color ToColor()
        {
            throw new NotImplementedException();
        }

        private static double Max(params double[] numbers)
        {
            return numbers.ToList().Max();
	    }

        private static double Min(params double[] numbers)
        {
            return numbers.ToList().Min();
	    }
    }

}
