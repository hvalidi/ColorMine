//Note: This is a generated file.
using System.Drawing;
using ColorMine.ColorSpaces.Conversions;

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
        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }

		public Hsl() {}

        public Hsl(Color color)
        {
            HslConverter.ToColorSpace(color,this);
        }

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
        public double L { get; set; }
        public double A { get; set; }
        public double B { get; set; }

		public Lab() {}

        public Lab(Color color)
        {
            LabConverter.ToColorSpace(color,this);
        }

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
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

		public Rgb() {}

        public Rgb(Color color)
        {
            RgbConverter.ToColorSpace(color,this);
        }

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
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

		public Xyz() {}

        public Xyz(Color color)
        {
            XyzConverter.ToColorSpace(color,this);
        }

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