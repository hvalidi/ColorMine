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
            var g = pivotRgb(color.G/255.0);
            var b = pivotRgb(color.B/255.0);

            // Observer. = 2°, Illuminant = D65
            X = r*0.4124 + g*0.3576 + b*0.1805;
            Y = r*0.2126 + g*0.7152 + b*0.0722;
            Z = r*0.0193 + g*0.1192 + b*0.9505;
        }

        public override Color ToColor()
        {
            // (Observer = 2°, Illuminant = D65)
            var var_X = X/100;
            var var_Y = Y/100;
            var var_Z = Z/100;

            var var_R = var_X*3.2406 + var_Y*-1.5372 + var_Z*-0.4986;
            var var_G = var_X*-0.9689 + var_Y*1.8758 + var_Z*0.0415;
            var var_B = var_X*0.0557 + var_Y*-0.2040 + var_Z*1.0570;

            if (var_R > 0.0031308)
                var_R = 1.055*Math.Pow(var_R, 1/2.4) - 0.055;
            else
                var_R = 12.92*var_R;

            if (var_G > 0.0031308)
                var_G = 1.055*Math.Pow(var_G,1/2.4) - 0.055;
            else
                var_G = 12.92*var_G;
            if (var_B > 0.0031308)
                var_B = 1.055*Math.Pow(var_B,1/2.4) - 0.055;
            else
                var_B = 12.92*var_B;

            return Color.FromArgb(255, (int)(var_R * 255), (int)(var_G * 255), (int)(var_B * 255));
        }

        private static double pivotRgb(double n)
        {
            return (n > 0.04045 ? Math.Pow((n + 0.055) / 1.055, 2.4) : n / 12.92) * 100;
        }
    }
}