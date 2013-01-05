namespace ColorMine.ColorSpaces
{
    internal class Xyz : ColorSpace
    {
        private double X
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        private double Y
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        private double Z
        {
            get { return this[2]; }
            set { this[2] = value; }
        }
    }
}