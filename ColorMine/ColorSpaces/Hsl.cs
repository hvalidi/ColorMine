using ColorMine.Utility;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    public class Hsl : ColorSpace
    {
        public double H { get { return this[0]; } set { this[0] = value; } }
        public double S { get { return this[1]; } set { this[1] = value; } }
        public double L { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            H = color.GetHue();
            S = color.GetSaturation();
            L = color.GetBrightness();
        }

        public override Color ToColor()
        {
            var rangedH = H/360;
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;

            if (!L.BasicallyEqualTo(0))
            {
                if (S.BasicallyEqualTo(0))
                {
                    r = g = b = L;
                }
                else
                {
                    var temp2 = (L < 0.5) ? L*(1.0 + S) : L + S - (L*S);
                    var temp1 = 2.0 * L - temp2;

                    r = GetColorComponent(temp1, temp2, rangedH + 1.0 / 3.0);
                    g = GetColorComponent(temp1, temp2, rangedH);
                    b = GetColorComponent(temp1, temp2, rangedH - 1.0 / 3.0);
                }
            }
            return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
        }

        private static double GetColorComponent(double temp1, double temp2, double temp3)
        {
            temp3 = MoveIntoRange(temp3);
            if (temp3 < 1.0 / 6.0)
            {
                return temp1 + (temp2 - temp1) * 6.0 * temp3;
            }

            if (temp3 < 0.5)
            {
                return temp2;
            }

            if (temp3 < 2.0 / 3.0)
            {
                return temp1 + ((temp2 - temp1) * ((2.0 / 3.0) - temp3) * 6.0);
            }

            return temp1;
        }

        private static double MoveIntoRange(double temp3)
        {
            if (temp3 < 0.0) return temp3 + 1;
            if (temp3 > 1.0) return temp3 - 1;
            return temp3;
        }
    }
}
