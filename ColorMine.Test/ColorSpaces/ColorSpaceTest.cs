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
			Assert.IsTrue(expectedColor.R.BasicallyEqualTo(target.R,Precision),expectedColor.R + " != " + target.R);
			Assert.IsTrue(expectedColor.G.BasicallyEqualTo(target.G,Precision),expectedColor.G + " != " + target.G);
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision),expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
		{
			var target = knownColor.To<Lab>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision),expectedColor.L + " != " + target.L);
			Assert.IsTrue(expectedColor.A.BasicallyEqualTo(target.A,Precision),expectedColor.A + " != " + target.A);
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision),expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
		{
			var target = knownColor.To<Xyz>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision),expectedColor.X + " != " + target.X);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision),expectedColor.Z + " != " + target.Z);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
		{
			var target = knownColor.To<Cmy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision),expectedColor.C + " != " + target.C);
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision),expectedColor.M + " != " + target.M);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),expectedColor.Y + " != " + target.Y);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
		{
			var target = knownColor.To<Cmyk>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision),expectedColor.C + " != " + target.C);
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision),expectedColor.M + " != " + target.M);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision),expectedColor.K + " != " + target.K);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
		{
			var target = knownColor.To<Yxy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision),expectedColor.Y1 + " != " + target.Y1);
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision),expectedColor.X + " != " + target.X);
			Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision),expectedColor.Y2 + " != " + target.Y2);
		}
	}

}