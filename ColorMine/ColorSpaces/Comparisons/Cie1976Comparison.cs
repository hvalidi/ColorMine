using System;

namespace ColorMine.ColorSpaces.Comparisons
{
    public class Cie1976Comparison : IDeltaEComparison
    {
        public double Compare(IColorSpace colorA, IColorSpace colorB)
        {
            var a = colorA.To<Lab>();
            var b = colorB.To<Lab>();

            var differences = Distance(a.L, b.L) + Distance(a.A, b.A) + Distance(a.B, b.B);
            return Math.Sqrt(differences);
        }

        private static double Distance(double a, double b)
        {
            return Math.Pow(a - b, 2);
        }
    }
}