namespace GOF.Visitor;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Customer customer = new();
        customer.Attach(new MidQuality());
        customer.Attach(new HighQuality());
        customer.Attach(new UltraHighQuality());

        customer.Accept(new SerivceFeesVisitor());
        customer.Accept(new PerMonthVisitor());

        Console.ReadKey();
    }
}