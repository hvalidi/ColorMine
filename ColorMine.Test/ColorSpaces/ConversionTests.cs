//Note: This is a generated file.
using ColorMine.ColorSpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{

	public class RgbTest
    {
		[TestClass]
        public class To : ColorSpaceTest
        {
			
			[TestMethod]
            public void WhiteRgbToRgb()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Rgb { R = 255, G = 255, B = 255, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void WhiteRgbToLab()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Lab { L = 100, A = 0, B = -.010, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void WhiteRgbToXyz()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Xyz { X = 95.050, Y = 100, Z = 108.900, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void WhiteRgbToCmy()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Cmy { C = 0, M = 0, Y = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void WhiteRgbToCmyk()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Cmyk { C = 0, M = 0, Y = 0, K = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void WhiteRgbToYxy()
            {
				var knownColor = new Rgb { R = 255, G = 255, B = 255, };
				var expectedColor = new Yxy { Y1 = 100, X = .31272, Y2 = .32900, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToRgb()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Rgb { R = 0, G = 0, B = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToLab()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Lab { L = 0, A = 0, B = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToXyz()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Xyz { X = 0, Y = 0, Z = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToCmy()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Cmy { C = 1, M = 1, Y = 1, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToCmyk()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Cmyk { C = 0, M = 0, Y = 0, K = 1, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void BlackRgbToYxy()
            {
				var knownColor = new Rgb { R = 0, G = 0, B = 0, };
				var expectedColor = new Yxy { Y1 = 0, X = 0, Y2 = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }

        }
	}
	public class LabTest
    {
		[TestClass]
        public class To : ColorSpaceTest
        {
			
			[TestMethod]
            public void RedLabToRgb()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Rgb { R = 255, G = 0.8, B = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void RedLabToLab()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void RedLabToXyz()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Xyz { X = 41.240, Y = 21.260, Z = 1.930, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void RedLabToCmy()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Cmy { C = 0, M = .99970, Y = 1, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void RedLabToCmyk()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Cmyk { C = 0, M = .99970, Y = 100, K = 0, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }
			
			[TestMethod]
            public void RedLabToYxy()
            {
				var knownColor = new Lab { L = 53.233, A = 80.109, B = 67.220, };
				var expectedColor = new Yxy { Y1 = 21.260, X = 0.64007, Y2 = .32997, };

                ExpectedValuesForKnownColor(knownColor,expectedColor);
            }

        }
	}
}