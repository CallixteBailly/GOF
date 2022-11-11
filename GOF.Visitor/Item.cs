namespace GOF.Visitor;

public class Item : Element
{
    public Item(string name, double serviceFees,
        int perMonth)
    {
        Name = name;
        SerivceFees = serviceFees;
        PerMonth = perMonth;
    }

    public string Name { get; set; }

    public double SerivceFees { get; set; }

    public int PerMonth { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
