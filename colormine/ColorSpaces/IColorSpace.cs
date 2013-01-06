using System.Drawing;

namespace ColorMine.ColorSpaces
{
    public delegate double ComparisonAlgorithm(IColorSpace a, IColorSpace b);

    public interface IColorSpace
    {
        void Initialize(Color color);
        Color ToColor();

        /// <summary>
        /// Convert any IColorSpace to any other IColorSpace
        /// </summary>
        /// <typeparam name="T">IColorSpace type to convert to</typeparam>
        /// <returns></returns>
        T To<T>() where T : IColorSpace, new();

        /// <summary>
        /// Determine how close two IColorSpaces are to each other using a passed in algorithm
        /// </summary>
        /// <param name="compareToValue">Other IColorSpace to compare to</param>
        /// <param name="algorithm">Algorithm to use for comparison</param>
        /// <returns>the distance in 3d space as double</returns>
        double Compare(IColorSpace compareToValue, ComparisonAlgorithm algorithm);       
    }
}