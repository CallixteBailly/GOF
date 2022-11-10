namespace GOF.Obsever;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
        Item item = new("Bose Q158", 200.00);
        item.Attach(new Customer("Anthony"));
        Customer customer = new("Kality");
        item.Attach(customer);
        Console.WriteLine($"Base Price: {item.Price}");
        item.Price = 190.10;
        item.Price = 199.00;
        item.Price = 188.50;

        item.Detach(customer);
        item.Price = 190.75;

        Console.ReadKey();
    }
}