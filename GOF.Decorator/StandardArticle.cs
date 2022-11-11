namespace GOF.Decorator
{
    public class StandardArticle : Article
    {
        private readonly string _categ;
        // Constructor
        public StandardArticle(string categ, string title, int remanings)
        {
            _categ = categ;
            Title = title;
            Remanings = remanings;
        }
        public override void Display()
        {
            Console.WriteLine("\nStandard Article ------ ");
            Console.WriteLine(" Categ: {0}", _categ);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Remaning: {0}", Remanings);
        }
    }
}
