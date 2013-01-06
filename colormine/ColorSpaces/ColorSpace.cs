using System;
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

    public abstract class ColorSpace : IColorSpace
    {
        public abstract void Initialize(Color color);
        public abstract Color ToColor();
        
        public double Compare(IColorSpace compareToValue, ComparisonAlgorithm algorithm)
        {
            return algorithm(this, compareToValue);
        }

        public T To<T>() where T : IColorSpace, new()
        {
            var newColorSpace = new T();
            newColorSpace.Initialize(this.ToColor());
            return newColorSpace;
        }
        
        private const int DataSize = 3;
        private readonly double[] _data = new double[DataSize];
        internal double this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _data[index];
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new ArgumentOutOfRangeException();
                }
                _data[index] = value;
            }
        }

        private bool IsValidIndex(int index)
        {
            return 0 <= index && index < _data.Length;
        }
    }
}