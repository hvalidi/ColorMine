using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ColorMine.Themes.Adapters
{
    internal sealed class BitmapAdapter : IImage
    {
        private readonly Bitmap _image;
        internal BitmapAdapter(Bitmap image)
        {
            _image = image;
        }

        public int Width
        {
            get { return _image.Width; }
        }

        public int Height
        {
            get { return _image.Height; }
        }

        public Color GetPixel(int x, int y)
        {
            return _image.GetPixel(x, y);
        }

        public void Save(Stream stream, ImageFormat format)
        {
            _image.Save(stream, format);
        }
    }
}