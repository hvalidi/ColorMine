using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.ColorSpaces;

namespace Test.ColorMine.ColorSpaces
{
    public class HslTest
    {
        [TestClass]
        public class H
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255;

                var target = new Hsl
                {
                    H = expected
                };

                Assert.AreEqual(expected, target.H);
            }

            [TestMethod]
            public void ThrowsExceptionForInappropriateValue()
            {
               Assert.Inconclusive("Not sure of Range");
            }
        }

        [TestClass]
        public class S
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 0;

                var target = new Hsl
                {
                    S = expected
                };

                Assert.AreEqual(expected, target.S);
            }

            [TestMethod]
            public void ThrowsExceptionForInappropriateValue()
            {
                Assert.Inconclusive("Not sure of Range");
            }
        }

        [TestClass]
        public class L
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Hsl
                {
                    L = expected
                };

                Assert.AreEqual(expected, target.L);
            }

            [TestMethod]
            public void ThrowsExceptionForInappropriateValue()
            {
                Assert.Inconclusive("Not sure of Range");
            }
        }

        [TestClass]
        public class Initialize
        {
            private void ExpectedValuesFromKnownColor(Color knownColor)
            {
                var target = new Hsl();
                target.Initialize(knownColor);

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
            [TestMethod]
            private void ExpectedColorFromKnownValues(Color knownColor)
            {
                var target = new Hsl
                {
                    H = knownColor.GetHue(),
                    S = knownColor.GetSaturation(),
                    L = knownColor.GetBrightness()
                };

                Assert.AreEqual(knownColor.GetHue(),target.H);
                Assert.AreEqual(knownColor.GetSaturation(), target.S);
                Assert.AreEqual(knownColor.GetBrightness(), target.L);
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
