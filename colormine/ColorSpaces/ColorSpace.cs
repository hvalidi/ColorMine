using System;

namespace ColorMine.ColorSpaces
{
    internal abstract class ColorSpace : IColorSpace
    {
        /// <summary>Determine how close two ColorTuples are to each other using the distance formula in three dimensional space.</summary>
        /// <param name="other">Other IColorSpace to compare to</param>
        /// <returns>the distance in 3d space as double</returns>
        public double Compare<T>(IColorSpace other) where T:IColorSpace
        {
            // first get them to the same space (T)
            var me = this.To<T>();
            var them = other.To<T>();

            var differences = Distance(me[0], them[0]) + Distance(me[1], them[1]) + Distance(me[2], them[2]);
            return Math.Sqrt(differences);
        }

        public T To<T>() where T:IColorSpace
        {
            throw new NotImplementedException("Need to do color conversions here");
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