namespace GOF.ChainOfResp;

public class ClaimLvlMedium : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 2000)
        {
            Console.WriteLine($"{GetType().Name} approved claim# {purchase.Id}");
        }
        else
        {
            successor?.ProcessRequest(purchase);
        }
    }
}
