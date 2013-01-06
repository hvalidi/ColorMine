using System;

namespace Test.ColorMine.ColorSpaces
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
