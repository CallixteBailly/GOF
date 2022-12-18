namespace GOF.Builder;

public class DigitalArticleBuilder : ArticleBuilder
{
    public DigitalArticleBuilder()
    {
        Article = new Article("Digital");
    }

    public override void BuildCategories()
    {
        Article.Categories = "Categ Digital";
    }

    public override void BuildDetails()
    {
        Article.Details = "Details Digital";
    }

    public override void BuildName()
    {
        Article.Name = "Name Digital";
    }

    public override void BuildPrices()
    {
        Article.Prices = 3;
    }
}