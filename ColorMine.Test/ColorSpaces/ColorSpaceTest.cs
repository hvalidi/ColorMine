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
			Assert.IsTrue(expectedColor.R.BasicallyEqualTo(target.R,Precision),"(R)" + expectedColor.R + " != " + target.R);
			Assert.IsTrue(expectedColor.G.BasicallyEqualTo(target.G,Precision),"(G)" + expectedColor.G + " != " + target.G);
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision),"(B)" + expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
		{
			var target = knownColor.To<Lab>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision),"(L)" + expectedColor.L + " != " + target.L);
			Assert.IsTrue(expectedColor.A.BasicallyEqualTo(target.A,Precision),"(A)" + expectedColor.A + " != " + target.A);
			Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision),"(B)" + expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
		{
			var target = knownColor.To<Xyz>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision),"(X)" + expectedColor.X + " != " + target.X);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),"(Y)" + expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision),"(Z)" + expectedColor.Z + " != " + target.Z);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
		{
			var target = knownColor.To<Cmy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision),"(C)" + expectedColor.C + " != " + target.C);
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision),"(M)" + expectedColor.M + " != " + target.M);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),"(Y)" + expectedColor.Y + " != " + target.Y);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
		{
			var target = knownColor.To<Cmyk>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision),"(C)" + expectedColor.C + " != " + target.C);
			Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision),"(M)" + expectedColor.M + " != " + target.M);
			Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision),"(Y)" + expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision),"(K)" + expectedColor.K + " != " + target.K);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
		{
			var target = knownColor.To<Yxy>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision),"(Y1)" + expectedColor.Y1 + " != " + target.Y1);
			Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision),"(X)" + expectedColor.X + " != " + target.X);
			Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision),"(Y2)" + expectedColor.Y2 + " != " + target.Y2);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IHsl expectedColor)
		{
			var target = knownColor.To<Hsl>();

			// TODO Shouldn't use ColorMine code to validate ColorMine code...
			Assert.IsTrue(expectedColor.H.BasicallyEqualTo(target.H,Precision),"(H)" + expectedColor.H + " != " + target.H);
			Assert.IsTrue(expectedColor.S.BasicallyEqualTo(target.S,Precision),"(S)" + expectedColor.S + " != " + target.S);
			Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision),"(L)" + expectedColor.L + " != " + target.L);
		}
	}

}