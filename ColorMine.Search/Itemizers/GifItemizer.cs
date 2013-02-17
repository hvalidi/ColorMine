using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using ColorMine.Search.Itemizers.Adapters;

namespace ColorMine.Search.Itemizers
{
    /// <summary>
    /// Converts an image into an IColorCatalog by converting to a gif and returning the converted colors
    /// </summary>
    public sealed class GifItemizer : IItemizerStrategy
    {
        public T Itemize<T>(IImage image) where T : ICatalog, new()
        {
            using(var stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Gif);
                return new T
                    {
                        Image = new BitmapAdapter(new Bitmap(stream))
                    };
            }
        }
    }
}