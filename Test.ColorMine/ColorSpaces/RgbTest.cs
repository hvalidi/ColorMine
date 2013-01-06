using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.ColorSpaces;

namespace Test.ColorMine.ColorSpaces
{
    public class RgbTest
    {
        [TestClass]
        public class R
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255;

                var target = new Rgb
                    {
                        R = expected
                    };

                Assert.AreEqual(expected, target.R);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void ThrowsExceptionForInappropriateValue()
            {
                var target = new Rgb
                {
                    R = -1
                };
            }
        }

        [TestClass]
        public class G
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 0;

                var target = new Rgb
                    {
                        G = expected
                    };

                Assert.AreEqual(expected, target.G);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void ThrowsExceptionForInappropriateValue()
            {
                var target = new Rgb
                {
                    G = -1
                };
            }
        }

        [TestClass]
        public class B
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Rgb
                    {
                        B = expected
                    };

                Assert.AreEqual(expected, target.B);
            }

            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void ThrowsExceptionForInappropriateValue()
            {
                var target = new Rgb
                {
                    B = -1
                };
            }
        }

        [TestClass]
        public class Initialize
        {
            private void ExpectedValuesFromKnownColor(Color knownColor)
            {
                var target = new Rgb();
                target.Initialize(knownColor);

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
            [TestMethod]
            private void ExpectedColorFromKnownValues(Color knownColor)
            {
                var target = new Rgb
                    {
                        R = knownColor.R,
                        G = knownColor.G,
                        B = knownColor.B
                    };

                var actual = target.ToColor();

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