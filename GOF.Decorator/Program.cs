namespace GOF.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create book
            StandardArticle sdArticle = new("Audio", "Sonos devalt", 5);
            sdArticle.Display();
            // Create video
            DigitalArticle dArticle = new("Ebook", ".NET", 10, "Developper");
            dArticle.Display();
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking digital article :");
            Cart dCart = new(dArticle);
            dCart.AddArticle("Customer #1");
            dCart.AddArticle("Customer #2");
            dCart.Display();

            Console.WriteLine("\nMaking standard article :");
            Cart sdCart = new(sdArticle);
            sdCart.AddArticle("Customer #3");
            sdCart.Display();
            // Wait for user
            _ = Console.ReadKey();
        }
    }
}