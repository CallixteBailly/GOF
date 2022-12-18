namespace GOF.Builder;

public abstract class ArticleBuilder
{
    public Article Article { get; set; } = null!;

    // Abstract build methods
    public abstract void BuildName();
    public abstract void BuildCategories();
    public abstract void BuildPrices();
    public abstract void BuildDetails();
}