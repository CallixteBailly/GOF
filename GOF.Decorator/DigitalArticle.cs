namespace GOF.Decorator
{
    public class DigitalArticle : Article
    {
        private readonly string _categ;
        private readonly string _subCateg;
        // Constructor
        public DigitalArticle(string categ, string title, int remanings, string subCateg)
        {
            _categ = categ;
            Title = title;
            Remanings = remanings;
            _subCateg = subCateg;
        }
        public override void Display()
        {
            Console.WriteLine("\nDigital Article ----- ");
            Console.WriteLine(" Categ: {0}", _categ);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Remanings: {0}", Remanings);
            Console.WriteLine(" SubCateg: {0}\n", _subCateg);
        }
    }
}
