namespace GOF.Builder;

public static class Order
{
    public static void Construct(ArticleBuilder articleBuilder)
    {
        articleBuilder.BuildName();
        articleBuilder.BuildCategories();
        articleBuilder.BuildPrices();
        articleBuilder.BuildDetails();
    }
}