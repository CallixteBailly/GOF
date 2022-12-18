namespace GOF.Iterator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            ItemsCollection collection = new();
            collection.AddItem(new Item()
            {
                Title = "First Item",
                Remaning = 3
            });
            collection.AddItem(new Item()
            {
                Title = "Second Item",
                Remaning = 2
            });
            collection.AddItem(new Item()
            {
                Title = "Third Item",
                Remaning = 1
            });

            Console.WriteLine("Straight traversal:");

            foreach (Item element in collection)
            {
                Console.WriteLine(element.Title);
            }

            Console.WriteLine("\nLinq:");

            foreach (Item element in collection.GetItems().OrderBy(o => o.Remaning).ToList())
            {
                Console.WriteLine(element.Title);
            }

            Console.WriteLine("\nReverse traversal:");

            collection.ReverseDirection();

            foreach (Item element in collection)
            {
                Console.WriteLine(element.Title);
            }
        }
    }
}