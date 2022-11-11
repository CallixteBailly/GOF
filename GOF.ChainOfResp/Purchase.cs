namespace GOF.ChainOfResp;
public class Purchase
{
    public Purchase(int number, double amount, string purpose)
    {
        Id = number;
        Amount = amount;
        Purpose = purpose;
    }
    public int Id { get; set; }
    public double Amount { get; set; }
    public string Purpose { get; set; }
}
