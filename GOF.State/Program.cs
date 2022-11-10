namespace GOF.State;

public class Program
{
    public static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
        // Open a new account

        Account account = new();

        // Apply Order history

        account.AddOrderHistory(500.0);
        account.AddOrderHistory(550.0);
        account.OrderToPay(1100.00);
        account.AddOrderHistory(10000000.0);

        Console.ReadKey();
    }
}