namespace ColorMine.ColorSpaces
{
    public interface IColorSpace
    {
        double Compare<T>(IColorSpace space) where T:IColorSpace;
        T To<T>() where T:IColorSpace;
        double this[int index] { get; set; }
    }
}