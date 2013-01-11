using System.Drawing;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Conversions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces.Conversions
{
    public class RgbConverterTest : ConverterTest
    {
        [TestClass]
        public class ToColorSpace
        {
            private static void ExpectedValuesFromKnownColor(Color knownColor)
            {
                var target = new Rgb();
                RgbConverter.ToColorSpace(knownColor, target);

                Assert.AreEqual(knownColor.R, target.R);
                Assert.AreEqual(knownColor.G, target.G);
                Assert.AreEqual(knownColor.B, target.B);
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
                var target = new Rgb
                    {
                        R = knownColor.R,
                        G = knownColor.G,
                        B = knownColor.B
                    };

                var actual = RgbConverter.ToColor(target);

                Assert.AreEqual(knownColor.ToArgb(), actual.ToArgb());
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