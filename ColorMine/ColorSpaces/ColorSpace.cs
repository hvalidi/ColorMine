using System.Drawing;
using ColorMine.ColorSpaces.Comparisons;

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
        /// <param name="comparer">Algorithm to use for comparison</param>
        /// <returns>the distance in 3d space as double</returns>
        double Compare(IColorSpace compareToValue, IColorSpaceComparison comparer);

        /// <summary>
        /// Gets or sets values based on ordinal
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        double this[int index] { get; set; }
    }

    public abstract class ColorSpace : IColorSpace
    {
        private readonly double[] _data = new double[3];
        public double this[int index] { get { return _data[index]; } set { _data[index] = value; } }

        public abstract void Initialize(Color color);

        public abstract Color ToColor();

        public double Compare(IColorSpace compareToValue, IColorSpaceComparison comparer)
        {
            return comparer.Compare(this, compareToValue);
        }

        public T To<T>() where T : IColorSpace, new()
        {
            // Don't need to convert a type that's already there, just clone it
            if (typeof(T) == GetType())
            {
                var clone = new T();
                clone[0] = this[0];
                clone[1] = this[1];
                clone[2] = this[2];
                return clone;
            }

            var newColorSpace = new T();
            newColorSpace.Initialize(ToColor());
            return newColorSpace;
        }

    }
}