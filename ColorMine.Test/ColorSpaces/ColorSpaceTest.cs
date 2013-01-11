using System;

namespace ColorMine.Test.ColorSpaces
{
    public abstract class ColorSpaceTest
    {
        protected static bool CloseEnough(int a, int b)
        {
            // TODO Too much tolerance!
            return Math.Abs(a - b) <= 5;
        }
    }
}
