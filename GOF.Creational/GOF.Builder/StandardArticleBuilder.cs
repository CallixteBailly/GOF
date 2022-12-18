namespace GOF.Builder;

public class StandardArticleBuilder : ArticleBuilder
{
    public StandardArticleBuilder()
    {
        Article = new Article("Standard");
    }

    public override void BuildCategories()
    {
        Article.Categories = "Categ Standard";
    }

    public override void BuildDetails()
    {
        Article.Details = "Details Standard";
    }

    public override void BuildName()
    {
        Article.Name = "Name Standard";
    }

    public override void BuildPrices()
    {
        Article.Prices = 1;
    }
}