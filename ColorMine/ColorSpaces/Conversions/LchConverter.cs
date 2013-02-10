using System;

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class LchConverter
    {
        // http://www.brucelindbloom.com/index.html?Eqn_Lab_to_LCH.html
        // http://www.easyrgb.com/index.php?X=MATH&H=09#text9
        // http://www.colourphil.co.uk/lab_lch_colour_space.html

        internal static void ToColorSpace(IRgb color, ILch item)
        {
            var lab = color.To<Lab>();
            var h = Math.Atan2(lab.B, lab.A);

            // convert from radians to degrees
            if (h > 0)
            {
                h = (h/Math.PI)*180;
            }
            else
            {
                h = 360 - (Math.Abs(h)/Math.PI)*180;
            }

            item.L = lab.L;
            item.C = Math.Sqrt(Math.Pow(lab.A,2) + Math.Pow(lab.B,2));
            item.H = h % 360;
        }

        internal static IRgb ToColor(ILch item)
        {
            var hRadians = (Math.PI * item.H) / 180.0;
            var lab = new Lab
                {
                    L = item.L,
                    A = Math.Cos(hRadians) * item.C,
                    B = Math.Sin(hRadians) * item.C
                };
            return lab.To<Rgb>();
        }

    }
}