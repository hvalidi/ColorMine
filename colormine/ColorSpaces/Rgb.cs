using System.Drawing;

namespace ColorMine.ColorSpaces
{
    public class Rgb : ColorSpace
    {
        public double R { get { return this[0]; } set { this[0] = value; } }
        public double G { get { return this[1]; } set { this[1] = value; } }
        public double B { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            R = color.R;
            G = color.G;
            B = color.B;
        }

        public override Color ToColor()
        {
            // TODO Not right...
            return Color.FromArgb(255, (int)R, (int)G, (int)B);
        }
    }
}