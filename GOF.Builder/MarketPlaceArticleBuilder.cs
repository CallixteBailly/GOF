namespace GOF.Builder;

public class MarketPlaceArticleBuilder : ArticleBuilder
{
    public MarketPlaceArticleBuilder()
    {
        Article = new Article("MarketPlace");
    }

    public override void BuildCategories()
    {
        Article.Categories = "Categ MarketPlace";
    }

    public override void BuildDetails()
    {
        Article.Details = "Details MarketPlace";
    }

    public override void BuildName()
    {
        Article.Name = "Name MarketPlace";
    }

    public override void BuildPrices()
    {
        Article.Prices = 2;
    }
}