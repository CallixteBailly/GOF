namespace GOF.Obsever;

public abstract class Stock
{
    private double _price;
    private readonly List<ICustomer> _customer = new();

    protected Stock(string symbol, double price)
    {
        Tittle = symbol;
        _price = price;
    }

    public void Attach(ICustomer customer)
    {
        _customer.Add(customer);
    }

    public void Detach(ICustomer customer)
    {
        _ = _customer.Remove(customer);
    }

    public void Notify()
    {
        foreach (ICustomer customer in _customer)
        {
            customer.Update(this);
        }

        Console.WriteLine("");
    }

    public double Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public string Tittle { get; }
}
