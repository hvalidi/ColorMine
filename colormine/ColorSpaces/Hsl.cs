using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
    internal class Hsl : ColorSpace
    {
        public double H { get { return this[0]; } set { this[0] = value; } }
        public double S { get { return this[1]; } set { this[1] = value; } }
        public double L { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            throw new NotImplementedException();
        }

        public override Color ToColor()
        {
            throw new NotImplementedException();
        }
    }

}
