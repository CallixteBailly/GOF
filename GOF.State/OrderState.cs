namespace GOF.State;

public abstract class OrderState
{
    public Account Account { get; set; } = null!;
    public double Balance { get; set; }
    public double UpperLimit { get; set; }

    public abstract void OrderHistory(double amount);
    public abstract void OrderToPay(double amount);
}
