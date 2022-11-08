namespace GOF.ChainOfResp;

public class ClaimLvlLow : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 1400)
        {
            Console.WriteLine($"{GetType().Name} approved claim# {purchase.Id}");
        }
        else if (successor != null)
        {
            successor.ProcessRequest(purchase);
        }
    }
}
