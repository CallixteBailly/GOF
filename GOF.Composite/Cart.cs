namespace GOF.Composite;
internal class Cart : OrderComposite
{
    public Cart(string name) : base(name)
    {
    }

    public override void Add(OrderComposite c)
    {
        Console.WriteLine("Cannot add to a cart");
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
    }

    public override void Remove(OrderComposite c)
    {
        Console.WriteLine("Cannot remove from a cart");
    }
}