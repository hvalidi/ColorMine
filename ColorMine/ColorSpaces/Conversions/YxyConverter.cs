using System.Drawing;

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class YxyConverter
    {
        internal static void ToColorSpace(Color color, IYxy item)
        {
            var xyz = new Xyz();
            xyz.Initialize(color);

            item.Y1 = xyz.Y;

            var xDividend = xyz.X + xyz.Y + xyz.Z;
            item.X = 0 == xDividend ? 0 : xyz.X / xDividend;

            var y2Dividend = xyz.X + xyz.Y + xyz.Z;
            item.Y2 = 0 == y2Dividend ? 0 : xyz.Y / (xyz.X + xyz.Y + xyz.Z);
        }

        internal static Color ToColor(IYxy item)
        {
            var xyz = new Xyz
                {
                    X = item.X*(item.Y1/item.Y2),
                    Y = item.Y1,
                    Z = (1 - item.X - item.Y2) * (item.Y1 / item.Y2)
                };
            return xyz.ToColor();
        }
    }
}