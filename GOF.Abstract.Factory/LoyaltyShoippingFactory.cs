namespace GOF.Abstract.Factory;
public class LoyaltyOrderPriority : IOrderPriority
{
    public int Priority => 1;
}
public class LoyaltyOrderPercentReduce : IOrderPercentReduce
{
    public decimal PercentReduce => 15m;
}
public class LoyaltyShoppingFactory : IShoppingFactory
{
    public IOrderPercentReduce GetPercentReduce()
    {
        return new LoyaltyOrderPercentReduce();
    }

    public IOrderPriority GetOrderPriority()
    {
        return new LoyaltyOrderPriority();
    }
}