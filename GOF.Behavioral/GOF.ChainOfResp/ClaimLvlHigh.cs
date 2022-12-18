namespace GOF.ChainOfResp;

public class ClaimLvlHigh : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 10000)
        {
            Console.WriteLine($"{GetType().Name} approved claim# {purchase.Id}");
        }
        else
        {
            Console.WriteLine($"Request# {purchase.Id} requires an executive meeting!");
        }
    }
}
