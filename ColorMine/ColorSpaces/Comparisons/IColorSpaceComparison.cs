namespace ColorMine.ColorSpaces.Comparisons
{
    public interface IColorSpaceComparison
    {
        /// <summary>
        ///     Compares two colors
        /// </summary>
        /// <param name="a">The first color</param>
        /// <param name="b">The second color</param>
        /// <returns>Score based on similarity, the lower the score the closer the colors</returns>
        double Compare(IColorSpace a, IColorSpace b);
    }
}