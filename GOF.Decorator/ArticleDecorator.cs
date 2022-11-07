namespace GOF.Decorator
{
    public abstract class ArticleDecorator : Article
    {
        protected Article article;
        // Constructor
        public ArticleDecorator(Article article)
        {
            this.article = article;
        }
        public override void Display()
        {
            article.Display();
        }
    }
}