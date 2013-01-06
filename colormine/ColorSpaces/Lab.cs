namespace ColorMine.ColorSpaces
{
    public class Lab : ColorSpace
    {
        public double L
        {
            get { return this[0]; }
            set { this[0] = value; }
        }

        public double A
        {
            get { return this[1]; }
            set { this[1] = value; }
        }

        public double B
        {
            get { return this[2]; }
            set { this[2] = value; }
        }
    }
}