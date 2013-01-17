using System.Drawing;
using ColorMine.Utility;

// dependent on Cmy

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class CmykConverter
    {
        internal static void ToColorSpace(Color color, ICmyk item)
        {
            var cmy = new Cmy();
            cmy.Initialize(color);

            var k = 1.0;
            if (item.C < k) k = item.C;
            if (item.M < k) k = item.M;
            if (item.Y < k) k = item.Y;
            item.K = k;

            if (k.BasicallyEqualTo(1))
            {
                item.C = 0;
                item.M = 0;
                item.Y = 0;
            }
            else
            {
                item.C = (item.C - k)/(1 - k);
                item.M = (item.M - k)/(1 - k);
                item.Y = (item.Y - k)/(1 - k);
            }
        }

        internal static Color ToColor(ICmyk item)
        {
            var cmy = new Cmy
                {
                    C = (item.C*(1 - item.K) + item.K),
                    M = (item.M*(1 - item.K) + item.K),
                    Y = (item.Y*(1 - item.K) + item.K)
                };

            return cmy.ToColor();
        }
    }
}