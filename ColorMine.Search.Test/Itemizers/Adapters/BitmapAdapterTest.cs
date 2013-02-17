using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ColorMine.Search.Itemizers.Adapters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColorMine.Search.Test.Itemizers.Adapters
{
    class BitmapAdapterTest
    {
        [TestClass]
        public class Width
        {
            [TestMethod]
            public void ReturnsExpectedValue()
            {
                var bitmap = new Bitmap(10, 10);
                var adapter = new BitmapAdapter(bitmap);

                Assert.AreEqual(bitmap.Width,adapter.Width);
            }
        }

        [TestClass]
        public class Height
        {
            [TestMethod]
            public void ReturnsExpectedValue()
            {
                var bitmap = new Bitmap(10, 10);
                var adapter = new BitmapAdapter(bitmap);

                Assert.AreEqual(bitmap.Height,adapter.Height);
            }
        }

        [TestClass]
        public class GetPixel
        {
            [TestMethod]
            public void ReturnsExpectedValue()
            {
                var color = Color.FromArgb(255, 255, 235, 205);
                var bitmap = new Bitmap(10, 10);
                bitmap.SetPixel(5, 7, color);

                var adapter = new BitmapAdapter(bitmap);

                Assert.AreEqual(color,adapter.GetPixel(5,7));
            }
        }

        [TestClass]
        public class Save
        {
            [TestMethod]
            public void NoError()
            {
                var color = Color.FromArgb(255, 153, 213, 255);
                var bitmap = new Bitmap(1, 1);
                bitmap.SetPixel(0, 0, color);
                var adapter = new BitmapAdapter(bitmap);

                using(var stream = new MemoryStream())
                {
                    adapter.Save(stream,ImageFormat.Gif);
                    var newBitmap = new Bitmap(stream);
                    Assert.AreEqual(color,newBitmap.GetPixel(0,0));
                }
            }
            
        }
    }
}
