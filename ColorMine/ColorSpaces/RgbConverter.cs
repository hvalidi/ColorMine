using System.Drawing;

namespace ColorMine.ColorSpaces
{
    internal static class RgbConverter
    {
        internal static void ToColorSpace(Color color, IRgb item)
        {
            item.R = color.R;
            item.G = color.G;
            item.B = color.B;
        }

        internal static Color ToColor(IRgb item)
        {
            return Color.FromArgb(255, (int)item.R, (int)item.G, (int)item.B);
        }

    }
}