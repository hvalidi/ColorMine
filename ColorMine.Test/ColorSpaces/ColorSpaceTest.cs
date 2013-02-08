//Note: This is a generated file.
using ColorMine.ColorSpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ColorMine.Test.ColorSpaces
{
	public abstract class ColorSpaceTest
    {

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IRgb expectedColor)
		{
			var target = knownColor.To<Rgb>();

			Assert.IsTrue(CloseEnough(expectedColor.R,target.R),"(R)" + expectedColor.R + " != " + target.R);
			Assert.IsTrue(CloseEnough(expectedColor.G,target.G),"(G)" + expectedColor.G + " != " + target.G);
			Assert.IsTrue(CloseEnough(expectedColor.B,target.B),"(B)" + expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
		{
			var target = knownColor.To<Lab>();

			Assert.IsTrue(CloseEnough(expectedColor.L,target.L),"(L)" + expectedColor.L + " != " + target.L);
			Assert.IsTrue(CloseEnough(expectedColor.A,target.A),"(A)" + expectedColor.A + " != " + target.A);
			Assert.IsTrue(CloseEnough(expectedColor.B,target.B),"(B)" + expectedColor.B + " != " + target.B);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
		{
			var target = knownColor.To<Xyz>();

			Assert.IsTrue(CloseEnough(expectedColor.X,target.X),"(X)" + expectedColor.X + " != " + target.X);
			Assert.IsTrue(CloseEnough(expectedColor.Y,target.Y),"(Y)" + expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(CloseEnough(expectedColor.Z,target.Z),"(Z)" + expectedColor.Z + " != " + target.Z);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
		{
			var target = knownColor.To<Cmy>();

			Assert.IsTrue(CloseEnough(expectedColor.C,target.C),"(C)" + expectedColor.C + " != " + target.C);
			Assert.IsTrue(CloseEnough(expectedColor.M,target.M),"(M)" + expectedColor.M + " != " + target.M);
			Assert.IsTrue(CloseEnough(expectedColor.Y,target.Y),"(Y)" + expectedColor.Y + " != " + target.Y);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
		{
			var target = knownColor.To<Cmyk>();

			Assert.IsTrue(CloseEnough(expectedColor.C,target.C),"(C)" + expectedColor.C + " != " + target.C);
			Assert.IsTrue(CloseEnough(expectedColor.M,target.M),"(M)" + expectedColor.M + " != " + target.M);
			Assert.IsTrue(CloseEnough(expectedColor.Y,target.Y),"(Y)" + expectedColor.Y + " != " + target.Y);
			Assert.IsTrue(CloseEnough(expectedColor.K,target.K),"(K)" + expectedColor.K + " != " + target.K);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
		{
			var target = knownColor.To<Yxy>();

			Assert.IsTrue(CloseEnough(expectedColor.Y1,target.Y1),"(Y1)" + expectedColor.Y1 + " != " + target.Y1);
			Assert.IsTrue(CloseEnough(expectedColor.X,target.X),"(X)" + expectedColor.X + " != " + target.X);
			Assert.IsTrue(CloseEnough(expectedColor.Y2,target.Y2),"(Y2)" + expectedColor.Y2 + " != " + target.Y2);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, IHsl expectedColor)
		{
			var target = knownColor.To<Hsl>();

			Assert.IsTrue(CloseEnough(expectedColor.H,target.H),"(H)" + expectedColor.H + " != " + target.H);
			Assert.IsTrue(CloseEnough(expectedColor.S,target.S),"(S)" + expectedColor.S + " != " + target.S);
			Assert.IsTrue(CloseEnough(expectedColor.L,target.L),"(L)" + expectedColor.L + " != " + target.L);
		}

		protected static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILch expectedColor)
		{
			var target = knownColor.To<Lch>();

			Assert.IsTrue(CloseEnough(expectedColor.L,target.L),"(L)" + expectedColor.L + " != " + target.L);
			Assert.IsTrue(CloseEnough(expectedColor.C,target.C),"(C)" + expectedColor.C + " != " + target.C);
			Assert.IsTrue(CloseEnough(expectedColor.H,target.H),"(H)" + expectedColor.H + " != " + target.H);
		}
		private static bool CloseEnough(double a, double b)
		{
			// Define the tolerance for variation in their values 
			var difference = Math.Abs(a * .01);

			// Compare the values 
			// The output to the console indicates that the two values are equal 
			return Math.Abs(a - b) <= difference;
		}

	}

}