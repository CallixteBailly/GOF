namespace GOF.Visitor;

public class Customer
{
    private readonly List<Item> _customers = new();

    public void Attach(Item employee)
    {
        _customers.Add(employee);
    }

    public void Detach(Item customer)
    {
        _ = _customers.Remove(customer);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (Item customer in _customers)
        {
            customer.Accept(visitor);
        }
        Console.WriteLine();
    }
}
