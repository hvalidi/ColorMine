//Note: This is a generated file.
using ColorMine.ColorSpaces;
using ColorMine.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{
	public class WhiteRgbToLabTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToLab
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
            {
                var target = knownColor.To<Lab>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision));
				Assert.IsTrue(expectedColor.A.BasicallyEqualTo(target.A,Precision));
				Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForWhite()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Lab { L = 100, A = 0, B = -.010, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class WhiteRgbToXyzTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToXyz
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
            {
                var target = knownColor.To<Xyz>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForWhite()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Xyz { X = 95.050, Y = 100, Z = 108.900, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class WhiteRgbToCmyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToCmy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
            {
                var target = knownColor.To<Cmy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForWhite()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Cmy { C = 0, M = 0, Y = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class WhiteRgbToCmykTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToCmyk
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
            {
                var target = knownColor.To<Cmyk>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForWhite()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Cmyk { C = 0, M = 0, Y = 0, K = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class WhiteRgbToYxyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToYxy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
            {
                var target = knownColor.To<Yxy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision));
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForWhite()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Yxy { Y1 = 100, X = .31272, Y2 = .32900, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class BlackRgbToLabTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToLab
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ILab expectedColor)
            {
                var target = knownColor.To<Lab>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.L.BasicallyEqualTo(target.L,Precision));
				Assert.IsTrue(expectedColor.A.BasicallyEqualTo(target.A,Precision));
				Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForBlack()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Lab { L = 0, A = 0, B = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class BlackRgbToXyzTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToXyz
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
            {
                var target = knownColor.To<Xyz>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForBlack()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Xyz { X = 0, Y = 0, Z = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class BlackRgbToCmyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToCmy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
            {
                var target = knownColor.To<Cmy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForBlack()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Cmy { C = 1, M = 1, Y = 1, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class BlackRgbToCmykTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToCmyk
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
            {
                var target = knownColor.To<Cmyk>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForBlack()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Cmyk { C = 0, M = 0, Y = 0, K = 100, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class BlackRgbToYxyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class RgbToYxy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
            {
                var target = knownColor.To<Yxy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision));
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForBlack()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Yxy { Y1 = 0, X = 0, Y2 = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class RedLabToRgbTest
    {
		private const double Precision = .01;

        [TestClass]
        public class LabToRgb
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IRgb expectedColor)
            {
                var target = knownColor.To<Rgb>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.R.BasicallyEqualTo(target.R,Precision));
				Assert.IsTrue(expectedColor.G.BasicallyEqualTo(target.G,Precision));
				Assert.IsTrue(expectedColor.B.BasicallyEqualTo(target.B,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForRed()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Rgb { R = 255, G = 0.8, B = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class RedLabToXyzTest
    {
		private const double Precision = .01;

        [TestClass]
        public class LabToXyz
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IXyz expectedColor)
            {
                var target = knownColor.To<Xyz>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.Z.BasicallyEqualTo(target.Z,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForRed()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Xyz { X = 41.240, Y = 21.260, Z = 1.930, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class RedLabToCmyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class LabToCmy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmy expectedColor)
            {
                var target = knownColor.To<Cmy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForRed()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Cmy { C = 0, M = .99970, Y = 1, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class RedLabToCmykTest
    {
		private const double Precision = .01;

        [TestClass]
        public class LabToCmyk
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, ICmyk expectedColor)
            {
                var target = knownColor.To<Cmyk>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.C.BasicallyEqualTo(target.C,Precision));
				Assert.IsTrue(expectedColor.M.BasicallyEqualTo(target.M,Precision));
				Assert.IsTrue(expectedColor.Y.BasicallyEqualTo(target.Y,Precision));
				Assert.IsTrue(expectedColor.K.BasicallyEqualTo(target.K,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForRed()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Cmyk { C = 0, M = .99970, Y = 100, K = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
		public class RedLabToYxyTest
    {
		private const double Precision = .01;

        [TestClass]
        public class LabToYxy
        {
			private static void ExpectedValuesForKnownColor(IColorSpace knownColor, IYxy expectedColor)
            {
                var target = knownColor.To<Yxy>();

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
				Assert.IsTrue(expectedColor.Y1.BasicallyEqualTo(target.Y1,Precision));
				Assert.IsTrue(expectedColor.X.BasicallyEqualTo(target.X,Precision));
				Assert.IsTrue(expectedColor.Y2.BasicallyEqualTo(target.Y2,Precision));
            }

            [TestMethod]
            public void ExpectedValuesForRed()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Yxy { Y1 = 21.260, X = 0.64007, Y2 = .32997, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
        }
	}
	
}