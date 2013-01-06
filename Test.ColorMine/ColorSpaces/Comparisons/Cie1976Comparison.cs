using System.Drawing;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Comparisons;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.Utility;

namespace Test.ColorMine.ColorSpaces.Comparisons
{
    public class Cie1976ComparisonTest
    {
        [TestClass]
        public class Compare
        {
            private void ReturnsExpectedValueForKnownInput(double expectedValue, IColorSpace a, IColorSpace b)
            {
                var target = new Cie1976Comparison();
                var actualValue = a.Compare(b, target);
                Assert.IsTrue(expectedValue.BasicallyEqualTo(actualValue));
            }

            [TestMethod]
            public void ReturnsZeroForSameColors()
            {
                var a = new Rgb();
                a.Initialize(Color.Red);

                var b = new Rgb();
                b.Initialize(Color.Red);

                ReturnsExpectedValueForKnownInput(0.0, a, b);
            }

            [TestMethod]
            public void ReturnsKnownValueForKnownColors()
            {
                var a = new Lab()
                    {
                        L = 50,
                        A = 67,
                        B = 88
                    };

                var b = new Lab
                    {
                        L = 50,
                        A = 15,
                        B = 22
                    };

                ReturnsExpectedValueForKnownInput(0.0, a, b);
            }
        }
    }
}
