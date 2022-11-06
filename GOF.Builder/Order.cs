namespace GOF.Builder;

public class Shop
{
    public void Construct(ArticleBuilder articleBuilder)
    {
        articleBuilder.BuildName();
        articleBuilder.BuildCategories();
        articleBuilder.BuildPrices();
        articleBuilder.BuildDetails();
    }
}