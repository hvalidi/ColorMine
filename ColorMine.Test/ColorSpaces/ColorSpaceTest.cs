//Note: This is a generated file.
using ColorMine.ColorSpaces;
using ColorMine.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{
	public abstract class ColorSpaceTest
    {
		private const double Precision = .01;

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IRgb expectedColor)
		{
			var target = knownColor.To<Rgb>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.R.BasicallyEqualTo(target.R,Precision));
			Assert.IsTrue(expectedColor.G.BasicallyEqualTo(target.G,Precision));
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision));
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
		{
			var target = knownColor.To<Lab>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision));
			Assert.IsTrue(expectedColor.A.BasicallyEqualTo(target.A,Precision));
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision));
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
		{
			var target = knownColor.To<Xyz>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
			Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision));
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
		{
			var target = knownColor.To<Cmy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
		{
			var target = knownColor.To<Cmyk>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
			Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision));
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
		{
			var target = knownColor.To<Yxy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision));
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
			Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision));
		}
	}

}