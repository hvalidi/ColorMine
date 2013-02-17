using System.Drawing;
using ColorMine.Search.Itemizers;
using ColorMine.Search.Itemizers.Adapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Search.Test.Itemizers
{
    public class GifItemizerTest
    {
        [TestClass]
        public class Itemize
        {
            private static void ColorConverted(Color startColor, Color destinationColor)
            {
                // TODO: Need to moq here, but it's difficult...
                var bitmap = new Bitmap(1, 1);
                bitmap.SetPixel(0, 0, startColor);
                var image = new BitmapAdapter(bitmap);

                var itemizer = new GifItemizer();
                var inventory = itemizer.Itemize<PercentagePaletteInventory>(image);

                Assert.IsTrue(inventory.Items.ContainsKey(destinationColor));
            }

            [TestMethod]
            public void SlightlyOffRedGetsConvertedToRed()
            {
                ColorConverted(Color.FromArgb(255, 255, 0, 1),Color.FromArgb(255, 255, 0, 0));
            }

            [TestMethod]
            public void SlightlyOffBlueGetsConvertedToBlue()
            {
                ColorConverted(Color.FromArgb(255, 1, 1, 255), Color.FromArgb(255, 0, 0, 255));
            }
        }
    }
}
