namespace ColorMine.Search.Itemizers
{
    interface IItemizer
    {
        T Itemize<T>(IImage image) where T : ICatalog, new();
    }
}