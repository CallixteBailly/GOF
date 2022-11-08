namespace GOF.Proxy;
/// <summary>
/// Proxy Design Pattern
/// </summary>

public class Program
{
    public static void Main(string[] args)
    {
        // Create proxy and request a service

        ProxyCart proxy = new ProxyCart();
        proxy.CreateShoppingCart();

        // Wait for user

        Console.ReadKey();
    }
}

