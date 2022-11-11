namespace GOF.Visitor;

public class PerMonthVisitor : IVisitor
{
    public void Visit(Element element)
    {
        Item? customer = element as Item;

        Console.WriteLine($"{customer?.GetType().Name} {customer?.Name}'s new vacation days: {customer?.PerMonth}");
    }
}
