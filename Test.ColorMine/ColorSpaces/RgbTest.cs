using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.ColorSpaces;

namespace Test.ColorMine.ColorSpaces
{
    [TestClass]
    public class RgbTest : ColorSpaceTest
    {
        [TestClass]
        public class R
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 255.0;

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
                Assert.Fail(target.ToString());
            }
        }

        [TestClass]
        public class G
        {
            [TestMethod]
            public void SavesAppropriateValue()
            {
                const double expected = 231.0;

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
                Assert.Fail(target.ToString());
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
                Assert.Fail(target.ToString());
            }
        }
    }
}
