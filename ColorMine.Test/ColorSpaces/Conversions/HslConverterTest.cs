using System.Drawing;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces.Conversions
{
    public class HslConverterTest : ConverterTest
    {
        [TestClass]
        public class ToColorSpace
        {
            private static void ExpectedValuesFromKnownColor(Color knownColor)
            {
                var target = new Hsl();
                HslConverter.ToColorSpace(knownColor, target);

                Assert.AreEqual(knownColor.GetHue(), target.H);
                Assert.AreEqual(knownColor.GetSaturation(), target.S);
                Assert.AreEqual(knownColor.GetBrightness(), target.L);
            }

            [TestMethod]
            public void ExpectedValuesFromTomato()
            {
                ExpectedValuesFromKnownColor(Color.Tomato);
            }

            [TestMethod]
            public void ExpectedValuesFromSpringGreen()
            {
                ExpectedValuesFromKnownColor(Color.SpringGreen);
            }

            [TestMethod]
            public void ExpectedValuesFromSteelBlue()
            {
                ExpectedValuesFromKnownColor(Color.SteelBlue);
            }
        }

        [TestClass]
        public class ToColor
        {
            private static void ExpectedColorFromKnownValues(Color knownColor)
            {
                var target = new Hsl
                    {
                        H = knownColor.GetHue(),
                        S = knownColor.GetSaturation(),
                        L = knownColor.GetBrightness()
                    };

                var actual = HslConverter.ToColor(target);

                Assert.IsTrue(CloseEnough(knownColor.R, actual.R));
                Assert.IsTrue(CloseEnough(knownColor.G, actual.G));
                Assert.IsTrue(CloseEnough(knownColor.B, actual.B));
            }

            [TestMethod]
            public void ExpectedColorFromDarkSalmon()
            {
                ExpectedColorFromKnownValues(Color.DarkSalmon);
            }

            [TestMethod]
            public void ExpectedColorFromDarkSeaGreen()
            {
                ExpectedColorFromKnownValues(Color.DarkSeaGreen);
            }

            [TestMethod]
            public void ExpectedColorFromDodgerBlue()
            {
                ExpectedColorFromKnownValues(Color.DodgerBlue);
            }
        }
    }
}