using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    internal class Xyz : ColorSpace
    {
        public double X { get { return this[0]; } set { this[0] = value; } }
        public double Y { get { return this[1]; } set { this[1] = value; } }
        public double Z { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            var r = pivotRgb(color.R/255.0);
            var g = pivotRgb(color.G / 255.0);
            var b = pivotRgb(color.B / 255.0);

            // Observer. = 2°, Illuminant = D65
            X = r*0.4124 + g*0.3576 + b*0.1805;
            Y = r*0.2126 + g*0.7152 + b*0.0722;
            Z = r*0.0193 + g*0.1192 + b*0.9505;
        }

        public override Color ToColor()
        {
            var r = 2.5623*X + (-1.1661)*Y + (-0.3962)*Z;
            var g = (-1.0215)*X + 1.9778*Y + 0.0437*Z;
            var b = 0.0752*X + (-0.2562)*Y + 1.1810*Z;

            return Color.FromArgb(255, (int)r, (int)g, (int)b);
        }

        private static double pivotRgb(double n)
        {
            return (n > 0.04045 ? Math.Pow((n + 0.055) / 1.055, 2.4) : n / 12.92) * 100;
        }
    }
}