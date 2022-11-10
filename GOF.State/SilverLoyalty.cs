namespace GOF.State;

public class SilverLoyalty : OrderState
{
    public SilverLoyalty(OrderState state) :
        this(state.Balance, state.Account)
    {
    }

    public SilverLoyalty(double balance, Account account)
    {
        Balance = balance;
        Account = account;
        Initialize();
    }

    private void Initialize()
    {
        // Should come from a datasource
        UpperLimit = 1000.0;
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
            Account.State = new HighLoyalty(this);
        }
        else if (Balance < UpperLimit)
        {
            Account.State = new HoodLoyalty(this);
        }
    }
}
