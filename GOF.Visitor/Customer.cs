namespace GOF.Visitor;

public class Customer
{
    private readonly List<Item> customers = new();

    public void Attach(Item employee)
    {
        customers.Add(employee);
    }

    public void Detach(Item customer)
    {
        customers.Remove(customer);
    }

    public void Accept(IVisitor visitor)
    {
        foreach (Item customer in customers)
        {
            customer.Accept(visitor);
        }
        Console.WriteLine();
    }
}
