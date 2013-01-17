using ColorMine.ColorSpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{
    public class CmykTest : ConverterTest
    {
        [TestClass]
        public class C
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255;
                // TODO Should be mocking!
                var target = new Cmyk
                {
                    C = expected
                };

                Assert.AreEqual(expected, target.C);
            }

        }

        [TestClass]
        public class M
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 0;

                var target = new Cmyk
                {
                    M = expected
                };

                Assert.AreEqual(expected, target.M);
            }
        }

        [TestClass]
        public class Y
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Cmyk
                {
                    Y = expected
                };

                Assert.AreEqual(expected, target.Y);
            }

        }

        [TestClass]
        public class K
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Cmyk
                {
                    K = expected
                };

                Assert.AreEqual(expected, target.K);
            }

        }
        [TestClass]
        public class Initialize
        {

            [TestMethod]
            public void ExpectedValuesFromTomato()
            {
                Assert.Inconclusive("Write me!");
            }

            [TestMethod]
            public void ExpectedValuesFromSpringGreen()
            {
                Assert.Inconclusive("Write me!");
            }

            [TestMethod]
            public void ExpectedValuesFromSteelBlue()
            {
                Assert.Inconclusive("Write me!");
            }
        }

        [TestClass]
        public class ToColor
        {
            [TestMethod]
            public void ExpectedColorFromDarkSalmon()
            {
                Assert.Inconclusive("Write me!");
            }

            [TestMethod]
            public void ExpectedColorFromDarkSeaGreen()
            {
                Assert.Inconclusive("Write me!");
            }

            [TestMethod]
            public void ExpectedColorFromDodgerBlue()
            {
                Assert.Inconclusive("Write me!");
            }

        }
    }
}
