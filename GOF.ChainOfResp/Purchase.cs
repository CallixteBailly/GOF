namespace GOF.ChainOfResp;
public class Purchase
{
    public Purchase(int number, double amount, string purpose)
    {
        this.Id = number;
        this.Amount = amount;
        this.Purpose = purpose;
    }
    public int Id { get; set; }
    public double Amount { get; set; }
    public string Purpose { get; set; }
}
