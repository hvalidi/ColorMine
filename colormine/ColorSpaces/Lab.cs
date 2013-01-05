namespace ColorMine.ColorSpaces
{
    internal class Lab : ColorSpace
    {
        private double L
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        private double A
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        private double B
        {
            get { return this[2]; }
            set { this[2] = value; }
        }
    }
}