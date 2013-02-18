using System;
using System.Drawing;
using ColorMine.Themes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Test.Themes
{
    class PercentagePaletteInventoryTest
    {
        [TestClass]
        public class Image
        {
            [TestMethod]
            public void EmptyImageReturnsEmptyPalette()
            {
                var image = new Moq.Mock<IImage>();
                image.Setup(x => x.Height).Returns(0);
                image.Setup(x => x.Width).Returns(0);

                var p = new PercentagePaletteInventory
                    {
                        Image = image.Object
                    };
                Assert.AreEqual(0,p.Items.Count);
            }

            private const double Epsilon = .1;

            [TestMethod]
            public void RedImageReturnsRedPalette()
            {
                var image = new Moq.Mock<IImage>();
                image.Setup(x => x.Width).Returns(1);
                image.Setup(x => x.Height).Returns(1);
                image.Setup(x => x.GetPixel(0,0)).Returns(Color.Red);

                var p = new PercentagePaletteInventory
                {
                    Image = image.Object
                };

                Assert.IsTrue(Math.Abs(p.Items[Color.Red] - 1) < Epsilon);
            }

            [TestMethod]
            public void MixedImageReturnsMixedPalette()
            {
                var image = new Moq.Mock<IImage>();
                image.Setup(x => x.Width).Returns(1);
                image.Setup(x => x.Height).Returns(2);
                image.Setup(x => x.GetPixel(0, 0)).Returns(Color.Red);
                image.Setup(x => x.GetPixel(0, 1)).Returns(Color.Blue);

                var p = new PercentagePaletteInventory
                {
                    Image = image.Object
                };

                // TODO: 2 Asserts, smells bad
                Assert.IsTrue(Math.Abs(p.Items[Color.Red] - .5) < Epsilon);
                Assert.IsTrue(Math.Abs(p.Items[Color.Blue] - .5) < Epsilon);
            }
        }
    }
}
