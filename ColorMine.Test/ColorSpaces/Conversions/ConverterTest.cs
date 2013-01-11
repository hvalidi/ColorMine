using System;

namespace ColorMine.Test.ColorSpaces.Conversions
{
    public abstract class ConverterTest
    {
        protected static bool CloseEnough(int a, int b)
        {
            // TODO Too much tolerance!
            // TODO DRY!
            return Math.Abs(a - b) <= 5;
        }
    }
}
