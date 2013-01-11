using System.Drawing;
using ColorMine.ColorSpaces.Comparisons;

namespace ColorMine.ColorSpaces
{
    public delegate double ComparisonAlgorithm(IColorSpace a, IColorSpace b);

    public interface IColorSpace
    {
        /// <summary>
        ///     Initialize settings from a System.Drawing.Color object
        /// </summary>
        /// <param name="color">System.Drawing.Color</param>
        void Initialize(Color color);

        /// <summary>
        ///     Convert the color space to a System.Drawing.Color object
        /// </summary>
        /// <returns>System.Drawing.Color object</returns>
        Color ToColor();

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

    public abstract class ColorSpace : IColorSpace
    {
        public abstract void Initialize(Color color);
        public abstract Color ToColor();

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
            newColorSpace.Initialize(ToColor());
                // TODO I hate this call, could get rid of the Initialize method otherwise
            return newColorSpace;
        }
    }
}