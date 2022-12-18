namespace GOF.Obsever;

public class Customer : ICustomer
{
    public string? Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {Name} of {stock.Tittle} change to {stock.Price:C}");
    }

    public Stock? Stock { get; set; }
}