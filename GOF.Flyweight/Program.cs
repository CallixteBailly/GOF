namespace GOF.Flyweight
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // The client code usually creates a bunch of pre-populated
            // flyweights in the initialization stage of the application.
            FlyweightFactory factory = new(
                new Order { Category = "Smartphone", Title = "Iphone 14 Pro Max 128go" },
                new Order { Category = "Audio", Title = "Bose Q150" },
                new Order { Category = "Computer", Title = "Espirion computer 16" },
                new Order { Category = "Book", Title = "Game of throne" },
                new Order { Category = "Ebook", Title = "Harry potter" }
            );
            factory.ListFlyweights();

            AddOrderToPoliceDatabase(factory, new Order
            {
                UniqueId = "CL234IR",
                Customer = "Bailly Kality",
                Category = "Audio",
                Title = "Bose Q150",
            });

            AddOrderToPoliceDatabase(factory, new Order
            {
                UniqueId = "A1SD54187EE",
                Customer = "Bailly Kality",
                Category = "Smartphone",
                Title = "Google pixel 7 pro 128go",
            });

            factory.ListFlyweights();
        }

        public static void AddOrderToPoliceDatabase(FlyweightFactory factory, Order order)
        {
            Console.WriteLine("\nClient: Adding a order to database.");

            Flyweight flyweight = factory.GetFlyweight(new Order
            {
                Title = order.Title,
                Category = order.Category
            }, factory.GetFlyweights());

            flyweight.Operation(order);
        }
    }
}