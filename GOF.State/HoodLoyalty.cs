namespace GOF.State;

public class HoodLoyalty : OrderState
{
    // Overloaded constructors
    public HoodLoyalty(OrderState state)
        : this(state.Balance, state.Account)
    {
    }

    public HoodLoyalty(double balance, Account account)
    {
        Balance = balance;
        Account = account;
        Initialize();
    }

    private void Initialize()
    {
        // Should come from a database
        UpperLimit = 100;
    }

    public override void OrderHistory(double amount)
    {
        Balance += amount;
        StateChangeCheck();
    }

    public override void OrderToPay(double amount)
    {
        Balance -= amount;
        StateChangeCheck();
    }



    private void StateChangeCheck()
    {
        if (Balance > UpperLimit)
        {
            Account.State = new SilverLoyalty(this);
        }
    }
}
