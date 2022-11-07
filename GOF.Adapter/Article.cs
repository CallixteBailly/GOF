namespace GOF.Adapter
{
    public enum ArticleType
    {
        Standard = 0,
        MarketPlace = 1,
        Digital = 2

    }
    public class Article
    {
        public string? Name { get; set; }
        public ArticleType Type { get; set; }
        public string? Category { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("\nArticle: Unknown ------ ");
        }
    }
}