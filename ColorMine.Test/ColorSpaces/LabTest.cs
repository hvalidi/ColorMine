using System.Drawing;
using ColorMine.ColorSpaces;
using ColorMine.Utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{
    public class LabTest : ColorSpaceTest
    {
        [TestClass]
        public class L
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255;
                // TODO Should be mocking!
                var target = new Lab
                    {
                        L = expected
                    };

                Assert.AreEqual(expected, target.L);
            }

        }

        [TestClass]
        public class A
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 0;

                var target = new Lab
                    {
                        A = expected
                    };

                Assert.AreEqual(expected, target.A);
            }

        }

        [TestClass]
        public class B
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Lab
                    {
                        B = expected
                    };

                Assert.AreEqual(expected, target.B);
            }

        }

        [TestClass]
        public class Initialize
        {
            private void ExpectedValuesFromKnownColor(Color knownColor, double expectedL, double expectedA, double expectedB)
            {
                var target = new Lab();
                target.Initialize(knownColor);

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
                ExpectedValuesFromKnownColor(Color.SpringGreen,88.473,-76.901,47.025);
            }

            [TestMethod]
            public void ExpectedValuesFromSteelBlue()
            {
                ExpectedValuesFromKnownColor(Color.SteelBlue,52.467,-4.070,-32.198);
            }
        }

        [TestClass]
        public class ToColor
        {
            [TestMethod]
            private void ExpectedColorFromKnownValues(Color knownColor, double expectedL, double expectedA, double expectedB)
            {
                var target = new Lab
                    {
                        L = expectedL,
                        A = expectedA,
                        B = expectedB
                    };

                var actual = target.ToColor();

                Assert.IsTrue(CloseEnough(knownColor.R, actual.R));
                Assert.IsTrue(CloseEnough(knownColor.G, actual.G));
                Assert.IsTrue(CloseEnough(knownColor.B, actual.B));
            }

            [TestMethod]
            public void ExpectedColorFromDarkSalmon()
            {
                ExpectedColorFromKnownValues(Color.DarkSalmon,68.819,27.989,28.748);
            }

            [TestMethod]
            public void ExpectedColorFromDarkSeaGreen()
            {
                ExpectedColorFromKnownValues(Color.DarkSeaGreen,72.087,-23.818,18.032);
            }

            [TestMethod]
            public void ExpectedColorFromDodgerBlue()
            {
                ExpectedColorFromKnownValues(Color.DodgerBlue,59.382,9.970,-63.395);
            }
        }
    }
}
