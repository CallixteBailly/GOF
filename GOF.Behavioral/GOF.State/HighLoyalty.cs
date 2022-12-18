namespace GOF.State;

public class HighLoyalty : OrderState
{
    public HighLoyalty(OrderState state)
    {
        Balance = state.Balance;
        Account = state.Account;
        Initialize();
    }

    private void Initialize()
    {
        // Should come from a datasource
        UpperLimit = 10000000.0;
    }

    public override void OrderHistory(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    public override void OrderToPay(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    private void StateChangeCheck()
    {
        if (Balance > UpperLimit)
        {
            Console.WriteLine("You spent too much on us!");
        }
    }
}
