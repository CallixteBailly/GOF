namespace GOF.Decorator
{
    public class DigitalArticle : Article
    {
        private readonly string categ;
        private readonly string subCateg;
        // Constructor
        public DigitalArticle(string categ, string title, int remanings, string subCateg)
        {
            this.categ = categ;
            Title = title;
            Remanings = remanings;
            this.subCateg = subCateg;
        }
        public override void Display()
        {
            Console.WriteLine("\nDigital Article ----- ");
            Console.WriteLine(" Categ: {0}", categ);
            Console.WriteLine(" Title: {0}", Title);
            Console.WriteLine(" # Remanings: {0}", Remanings);
            Console.WriteLine(" SubCateg: {0}\n", subCateg);
        }
    }
}
