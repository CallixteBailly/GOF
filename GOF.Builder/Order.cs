namespace GOF.Builder;

public class Order
{
    public void Construct(ArticleBuilder articleBuilder)
    {
        articleBuilder.BuildName();
        articleBuilder.BuildCategories();
        articleBuilder.BuildPrices();
        articleBuilder.BuildDetails();
    }
}