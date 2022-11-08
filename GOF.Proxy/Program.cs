namespace GOF.Proxy;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        ProxyCart proxy = new();
        proxy.CreateShoppingCart();

        Console.ReadKey();
    }
}
