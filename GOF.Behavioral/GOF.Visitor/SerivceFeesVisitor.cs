namespace GOF.Visitor;

public class SerivceFeesVisitor : IVisitor
{
    public void Visit(Element element)
    {
        Item? customer = element as Item;
        customer!.SerivceFees += 10.50;

        Console.WriteLine($"{customer?.GetType().Name} {customer?.Name}'s new vacation days: {customer?.SerivceFees}");
    }
}
