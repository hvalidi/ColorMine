using System;

namespace ColorMine.ColorSpaces.Comparisons
{
    public class CmcComparison : IDeltaEComparison
    {
        public const double DefaultLightness = 2.0;
        public const double DefaultChroma = 1.0;

        public double Lightness = DefaultLightness;
        public double Chroma = DefaultChroma;

        public CmcComparison(double lightness = DefaultLightness, double chroma = DefaultChroma)
        {
            Lightness = lightness;
        }

        public double Compare(IColorSpace colorA, IColorSpace colorB)
        {
            // TODO Where does the weight fit in?
            var aLab = colorA.To<Lab>();
            var bLab = colorB.To<Lab>();

            var deltaL = aLab.L - bLab.L;
            var h = Math.Atan2(aLab.B,aLab.A);

            var c1 = Math.Sqrt(Math.Pow(aLab.A, 2) + Math.Pow(aLab.B, 2));
            var c2 = Math.Sqrt(Math.Pow(bLab.A, 2) + Math.Pow(bLab.B, 2));
            var deltaC = c1 - c2;

            var deltaH = Math.Sqrt(Math.Pow(aLab.A - aLab.A, 2) + Math.Pow(aLab.B - aLab.B, 2) - deltaC);

            var t = 164 <= h || h >= 345
                        ? .56 + Math.Abs(.2*Math.Cos(h + 168.0))
                        : .36 + Math.Abs(.4*Math.Cos(h + 35.0));
            var f = Math.Sqrt(Math.Pow(c1,4)/(Math.Pow(c1,4) + 1900.0));

            var sL = aLab.L < 16 ? .511 : (.040975 * aLab.L) / (1.0 + .01765 * aLab.L);
            var sC = (.0638 * c1) / (1 + .0131 * c1) + .638;
            var sH = sC*(f*t + 1 - f);

            var differences = DistanceDivided(deltaL, Lightness * sL) +
                              DistanceDivided(deltaC, Chroma * sC) +
                              DistanceDivided(deltaH, sH);

            return Math.Sqrt(differences);
        }

        private static double DistanceDivided(double a, double b, double dividend)
        {
            return Math.Pow((a - b) / dividend, 2);
        }

        private static double DistanceDivided(double a, double dividend)
        {
            return Math.Pow(a / dividend, 2);
        }
    }
}