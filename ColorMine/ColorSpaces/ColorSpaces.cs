 
using System.Drawing;

namespace ColorMine.ColorSpaces
{
      public interface IHsl : IColorSpace
    {
        double H { get; set; }
        double S { get; set; }
        double L { get; set; }
    }

    public class Hsl : ColorSpace, IHsl
    {
        public double H { get { return this[0]; } set { this[0] = value; } }
        public double S { get { return this[1]; } set { this[1] = value; } }
        public double L { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            HslConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return HslConverter.ToColor(this);
        }
    }
	    public interface ILab : IColorSpace
    {
        double L { get; set; }
        double A { get; set; }
        double B { get; set; }
    }

    public class Lab : ColorSpace, ILab
    {
        public double L { get { return this[0]; } set { this[0] = value; } }
        public double A { get { return this[1]; } set { this[1] = value; } }
        public double B { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            LabConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return LabConverter.ToColor(this);
        }
    }
	    public interface IRgb : IColorSpace
    {
        double R { get; set; }
        double G { get; set; }
        double B { get; set; }
    }

    public class Rgb : ColorSpace, IRgb
    {
        public double R { get { return this[0]; } set { this[0] = value; } }
        public double G { get { return this[1]; } set { this[1] = value; } }
        public double B { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            RgbConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return RgbConverter.ToColor(this);
        }
    }
	    public interface IXyz : IColorSpace
    {
        double X { get; set; }
        double Y { get; set; }
        double Z { get; set; }
    }

    public class Xyz : ColorSpace, IXyz
    {
        public double X { get { return this[0]; } set { this[0] = value; } }
        public double Y { get { return this[1]; } set { this[1] = value; } }
        public double Z { get { return this[2]; } set { this[2] = value; } }

        public override void Initialize(Color color)
        {
            XyzConverter.ToColorSpace(color,this);
        }

        public override Color ToColor()
        {
            return XyzConverter.ToColor(this);
        }
    }
	}