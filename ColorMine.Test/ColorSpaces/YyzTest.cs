using ColorMine.ColorSpaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.ColorSpaces
{
    public class YyzTest : ConverterTest
    {
        [TestClass]
        public class Y1
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255;
                // TODO Should be mocking!
                var target = new Yxy
                {
                    Y1 = expected
                };

                Assert.AreEqual(expected, target.Y1);
            }

        }

        [TestClass]
        public class X
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 0;

                var target = new Yxy
                {
                    X = expected
                };

                Assert.AreEqual(expected, target.X);
            }
        }

        [TestClass]
        public class Y2
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 2.0;

                var target = new Yxy
                {
                    Y2 = expected
                };

                Assert.AreEqual(expected, target.Y2);
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
