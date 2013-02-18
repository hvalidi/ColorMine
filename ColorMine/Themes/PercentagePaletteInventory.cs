using System.Collections.Generic;
using System.Drawing;

namespace ColorMine.Themes
{
    public sealed class PercentagePaletteInventory : ICatalog
    {
        public IDictionary<Color, double> Items { get; private set; }

        public IImage Image
        {
            set
            {
                var items = new Dictionary<Color, double>();

                if (value.Width == 0 || value.Height == 0)
                {
                    Items = items;
                    return;
                }

                var increment = 1.0/(value.Width * value.Height);
                for (var y = 0; y < value.Height; y++)
                {
                    for (var x = 0; x < value.Width; x++)
                    {
                        var color = value.GetPixel(x, y);
                        items[color] = items.ContainsKey(color) ? items[color] + increment : increment;
                    }
                }
                Items = items;
            }
        }
    }
}