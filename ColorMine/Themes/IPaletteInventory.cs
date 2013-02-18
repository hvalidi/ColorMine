using System.Collections.Generic;
using System.Drawing;

namespace ColorMine.Themes
{
    public interface ICatalog
    {
        IDictionary<Color, double> Items { get; }
        IImage Image { set; }
    }
}