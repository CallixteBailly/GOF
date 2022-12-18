namespace GOF.Abstract.Factory;
public class Customer
{
    public int[] Orders { get; set; } = Array.Empty<int>();
}
public class ShoppingCart
{
    private readonly IShoppingFactory _factory;

    public ShoppingCart(IShoppingFactory factory)
    {
        _factory = factory;
    }

    public void ToOrder()
    {
        Console.WriteLine($"Priority {_factory.GetOrderPriority().Priority}");
        Console.WriteLine($"Percent {_factory.GetPercentReduce().PercentReduce}");
    }
}