namespace GOF.State;

public class Account
{
    public Account()
    {
        // New accounts are 'Silver' by default
        State = new SilverLoyalty(0.0, this);
    }

    public double Balance => State.Balance;

    public OrderState State { get; set; }

    public void AddOrderHistory(double amount)
    {
        State.OrderHistory(amount);
        Console.WriteLine($"Order {amount:C} => ");
        Console.WriteLine($" Balance = {Balance:C}");
        Console.WriteLine($" Loyalty Rank  = {State.GetType().Name}");
        Console.WriteLine("");
    }

    public void OrderToPay(double amount)
    {
        State.OrderToPay(amount);
        Console.WriteLine($"Order {amount:C} => ");
        Console.WriteLine($" Balance = {Balance:C}");
        Console.WriteLine($" Loyalty Rank  = {State.GetType().Name} \n");
    }
}
