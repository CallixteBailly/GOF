namespace GOF.Bridge;

public class RefinedArticleAbstraction : ArticleAbstraction
{
    public override void ToOrder()
    {
        Article?.ToOrder();
    }
}