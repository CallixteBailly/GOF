namespace GOF.Obsever;

public abstract class Stock
{
    private double price;
    private readonly List<ICustomer> Customer = new();

    protected Stock(string symbol, double price)
    {
        Tittle = symbol;
        this.price = price;
    }

    public void Attach(ICustomer customer)
    {
        Customer.Add(customer);
    }

    public void Detach(ICustomer customer)
    {
        Customer.Remove(customer);
    }

    public void Notify()
    {
        foreach (ICustomer customer in Customer)
        {
            customer.Update(this);
        }

        Console.WriteLine("");
    }

    public double Price
    {
        get => price;
        set
        {
            if (price != value)
            {
                price = value;
                Notify();
            }
        }
    }

    public string Tittle { get; }
}
