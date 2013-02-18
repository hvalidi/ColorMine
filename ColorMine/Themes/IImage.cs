using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ColorMine.Themes
{
    public interface IImage
    {
        int Width { get; }
        int Height { get; }
        Color GetPixel(int x, int y);
        void Save(Stream stream, ImageFormat format);
    }
}
