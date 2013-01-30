using System.Drawing;
using ColorMine.ColorSpaces.Comparisons;

namespace ColorMine.ColorSpaces
{
    public delegate double ComparisonAlgorithm(IColorSpace a, IColorSpace b);

    public interface IColorSpace
    {
        /// <summary>
        ///     Initialize settings from an Rgb object
        /// </summary>
        /// <param name="color">System.Drawing.Color</param>
        void Initialize(IRgb color);

        /// <summary>
        ///     Convert the color space to a Rgb, you should probably using the "To" method instead.
        /// </summary>
        /// <returns>System.Drawing.Color object</returns>
        IRgb ToRgb();

        /// <summary>
        ///     Convert any IColorSpace to any other IColorSpace
        /// </summary>
        /// <typeparam name="T">IColorSpace type to convert to</typeparam>
        /// <returns></returns>
        T To<T>() where T : IColorSpace, new();

        /// <summary>
        ///     Determine how close two IColorSpaces are to each other using a passed in algorithm
        /// </summary>
        /// <param name="compareToValue">Other IColorSpace to compare to</param>
        /// <param name="comparer">Algorithm to use for comparison</param>
        /// <returns>the distance in 3d space as double</returns>
        double Compare(IColorSpace compareToValue, IColorSpaceComparison comparer);
    }

    internal interface IColorConvertable
    {
        
    }

    public abstract class ColorSpace : IColorSpace
    {
        public abstract void Initialize(IRgb color);
        public abstract IRgb ToRgb();

        public double Compare(IColorSpace compareToValue, IColorSpaceComparison comparer)
        {
            return comparer.Compare(this, compareToValue);
        }

        public T To<T>() where T : IColorSpace, new()
        {
            if (typeof (T) == GetType())
            {
                return (T) MemberwiseClone();
            }

            var newColorSpace = new T();
            newColorSpace.Initialize(ToRgb());

            return newColorSpace;
        }
    }
}