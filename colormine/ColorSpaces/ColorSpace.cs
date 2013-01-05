using System;

namespace ColorMine.ColorSpaces
{
    internal abstract class ColorSpace : IColorSpace
    {
        /// <summary>Determine how close two ColorTuples are to each other using the distance formula in three dimensional space.</summary>
        /// <param name="other">Other IColorSpace to compare to</param>
        /// <returns>the distance in 3d space as double</returns>
        public double Compare(IColorSpace other)
        {
            var differences = Distance(this[0], other[0]) + Distance(this[1], other[1]) + Distance(this[2], other[2]);
            return Math.Sqrt(differences);
        }

        private const int DataSize = 3;
        private readonly double[] _data = new double[DataSize];
        public double this[int index]
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

        public override int GetHashCode()
        {
            return _data.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (null == obj) return false;

            var otherColorSpace = obj as ColorSpace;
            if (null == otherColorSpace) return false;

            for (var i = 0; i < _data.Length; i++)
            {
                if (!this[i].IsCloseTo(otherColorSpace[i])) return false;
            }

            return true;
        }

        private double Distance(double a, double b)
        {
            return Math.Pow(a - b, 2);
        }

        private bool IsValidIndex(int index)
        {
            return 0 < index && index < _data.Length;
        }
    }
}