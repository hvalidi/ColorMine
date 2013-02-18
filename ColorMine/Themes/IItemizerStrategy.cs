namespace ColorMine.Themes
{
    interface IItemizerStrategy
    {
        T Itemize<T>(IImage image) where T : ICatalog, new();
    }
}