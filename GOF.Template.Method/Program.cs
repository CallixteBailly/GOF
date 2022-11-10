namespace GOF.Template.Method;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        DataAccessor categories = new Categories();
        categories.Run(5);

        DataAccessor products = new Items();
        products.Run(3);

        Console.ReadKey();
    }
}