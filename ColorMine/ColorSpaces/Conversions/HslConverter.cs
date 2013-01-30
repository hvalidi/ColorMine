using System.Drawing;
using ColorMine.Utility;

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class HslConverter
    {
        internal static void ToColorSpace(IRgb color, IHsl item)
        {
            // TODO Losing precision
            var msColor = Color.FromArgb((int)color.R, (int)color.G, (int)color.B);
            item.H = msColor.GetHue();
            item.S = msColor.GetSaturation() * 100;
            item.L = msColor.GetBrightness() * 100;
        }

        internal static IRgb ToColor(IHsl item)
        {
            var rangedH = item.H/360.0;
            var r = 0.0;
            var g = 0.0;
            var b = 0.0;
            var s = item.S / 100;
            var l = item.L/100;

            if (!l.BasicallyEqualTo(0))
            {
                if (s.BasicallyEqualTo(0))
                {
                    r = g = b = l;
                }
                else
                {
                    var temp2 = (l < 0.5) ? l*(1.0 + s) : l + s - (l*s);
                    var temp1 = 2.0*l - temp2;

                    r = GetColorComponent(temp1, temp2, rangedH + 1.0/3.0);
                    g = GetColorComponent(temp1, temp2, rangedH);
                    b = GetColorComponent(temp1, temp2, rangedH - 1.0/3.0);
                }
            }
            return new Rgb
                {
                    R = 255*r,
                    G = 255*g,
                    B = 255*b
                };
        }

        private static double GetColorComponent(double temp1, double temp2, double temp3)
        {
            temp3 = MoveIntoRange(temp3);
            if (temp3 < 1.0/6.0)
            {
                return temp1 + (temp2 - temp1)*6.0*temp3;
            }

            if (temp3 < 0.5)
            {
                return temp2;
            }

            if (temp3 < 2.0/3.0)
            {
                return temp1 + ((temp2 - temp1)*((2.0/3.0) - temp3)*6.0);
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