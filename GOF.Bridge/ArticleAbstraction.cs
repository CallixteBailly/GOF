namespace GOF.Bridge;

public class ArticleAbstraction
{
    public Article? Article { get; set; }
    public virtual void ToOrder()
    {
        Article?.ToOrder();
    }
}