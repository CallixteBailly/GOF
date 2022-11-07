namespace GOF.Decorator
{
    public class StandardArticle : Article
    {
        private readonly string categ;
        // Constructor
        public StandardArticle(string categ, string title, int remanings)
        {
            this.categ = categ;
            Title = title;
            Remanings = remanings;
        }
        public override void Display()
        {
            Console.WriteLine("\nStandard Article ------ ");
            Console.WriteLine(" Categ: {0}", categ);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Remaning: {0}", Remanings);
        }
    }
}
