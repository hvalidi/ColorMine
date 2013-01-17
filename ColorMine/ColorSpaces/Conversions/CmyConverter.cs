using System.Drawing;

namespace ColorMine.ColorSpaces.Conversions
{
    internal static class CmyConverter
    {
        internal static void ToColorSpace(Color color, ICmy item)
        {
            item.C = 1 - (color.R/255);
            item.M = 1 - (color.G/255);
            item.Y = 1 - (color.B/255);
        }

        internal static Color ToColor(ICmy item)
        {
            return Color.FromArgb(0, (int)(1 - item.C) * 255, (int)(1 - item.M) * 255, (int)(1 - item.Y) * 255);
        }
    }
}