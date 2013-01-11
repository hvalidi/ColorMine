using System.Drawing;
using ColorMine.ColorSpaces;
using ColorMine.ColorSpaces.Conversions;
using ColorMine.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces.Conversions
{
    public class LabConverterTest : ConverterTest
    {
        [TestClass]
        public class ToColorSpace
        {
            private static void ExpectedValuesFromKnownColor(Color knownColor, double expectedL, double expectedA,
                                                      double expectedB)
            {
                var target = new Lab();
                LabConverter.ToColorSpace(knownColor, target);

                // TODO Shouldn't use ColorMine code to validate ColorMine code...
                Assert.IsTrue(expectedL.BasicallyEqualTo(target.L));
                Assert.IsTrue(expectedA.BasicallyEqualTo(target.A));
                Assert.IsTrue(expectedB.BasicallyEqualTo(target.B));
            }

            [TestMethod]
            public void ExpectedValuesFromTomato()
            {
                ExpectedValuesFromKnownColor(Color.Tomato, 62.201, 57.861, 46.417);
            }

            [TestMethod]
            public void ExpectedValuesFromSpringGreen()
            {
                ExpectedValuesFromKnownColor(Color.SpringGreen, 88.473, -76.901, 47.025);
            }

            [TestMethod]
            public void ExpectedValuesFromSteelBlue()
            {
                ExpectedValuesFromKnownColor(Color.SteelBlue, 52.467, -4.070, -32.198);
            }
        }

        [TestClass]
        public class ToColor
        {
            private static void ExpectedColorFromKnownValues(Color knownColor, double expectedL, double expectedA,
                                                      double expectedB)
            {
                var target = new Lab
                    {
                        L = expectedL,
                        A = expectedA,
                        B = expectedB
                    };
                var actual = LabConverter.ToColor(target);

                Assert.IsTrue(CloseEnough(knownColor.R, actual.R));
                Assert.IsTrue(CloseEnough(knownColor.G, actual.G));
                Assert.IsTrue(CloseEnough(knownColor.B, actual.B));
            }

            [TestMethod]
            public void ExpectedColorFromDarkSalmon()
            {
                ExpectedColorFromKnownValues(Color.DarkSalmon, 68.819, 27.989, 28.748);
            }

            [TestMethod]
            public void ExpectedColorFromDarkSeaGreen()
            {
                ExpectedColorFromKnownValues(Color.DarkSeaGreen, 72.087, -23.818, 18.032);
            }

            [TestMethod]
            public void ExpectedColorFromDodgerBlue()
            {
                ExpectedColorFromKnownValues(Color.DodgerBlue, 59.382, 9.970, -63.395);
            }
        }
    }
}