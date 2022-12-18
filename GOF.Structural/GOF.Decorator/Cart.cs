namespace GOF.Decorator
{
    public class Cart : ArticleDecorator
    {
        protected readonly List<string> articles = new();
        // Constructor
        public Cart(Article article)
            : base(article)
        {
        }
        public void AddArticle(string name)
        {
            articles.Add(name);
            article.Remanings--;
        }
        public void RemoveArticle(string name)
        {
            _ = articles.Remove(name);
            article.Remanings++;
        }
        public override void Display()
        {
            base.Display();
            foreach (string article in articles)
            {
                Console.WriteLine($" Customer: {article} making {this.article.Title}");
            }
        }
    }
}
