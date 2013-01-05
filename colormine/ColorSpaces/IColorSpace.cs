namespace ColorMine.ColorSpaces
{
    public interface IColorSpace
    {
        double Compare(IColorSpace space);
        double this[int index] { get; set; }
    }
}