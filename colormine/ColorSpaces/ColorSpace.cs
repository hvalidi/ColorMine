using System;
using System.Drawing;

namespace ColorMine.ColorSpaces
{
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
            return 0 < index && index < _data.Length;
        }
    }
}