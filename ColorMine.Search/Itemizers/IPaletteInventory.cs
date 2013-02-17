using System.Collections.Generic;
using System.Drawing;

namespace ColorMine.Search.Itemizers
{
    public interface ICatalog
    {
        IDictionary<Color, double> Items { get; }
        IImage Image { set; }
    }
}