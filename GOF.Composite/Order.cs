internal class Order : OrderComposite
{
    private readonly List<OrderComposite> _orders = new();
    public Order(string name) : base(name)
    {
    }

    public override void Add(OrderComposite o)
    {
        _orders.Add(o);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + name);
        // Recursively display child nodes
        foreach (OrderComposite order in _orders)
        {
            order.Display(depth + 2);
        }
    }

    public override void Remove(OrderComposite o)
    {
        _ = _orders.Remove(o);
    }
}