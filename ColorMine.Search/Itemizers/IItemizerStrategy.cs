namespace ColorMine.Search.Itemizers
{
    interface IItemizerStrategy
    {
        T Itemize<T>(IImage image) where T : ICatalog, new();
    }
}