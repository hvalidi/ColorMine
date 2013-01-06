using Microsoft.VisualStudio.TestTools.UnitTesting;
using ColorMine.Utility;

namespace Test.ColorMine.Utility
{
    [TestClass]
    public class DoubleExtensionTest
    {
        [TestClass]
        public class BasicallyEqualTo
        {
            [TestMethod]
            public void ReturnsTrueForCloseNumbers()
            {
                Assert.IsTrue(.3333.BasicallyEqualTo(1.0/3,.001));
            }

            [TestMethod]
            public void ReturnsFalseForFarNumbers()
            {
                Assert.IsFalse(.9.BasicallyEqualTo(.1,.001));
            }
        }
    }
}