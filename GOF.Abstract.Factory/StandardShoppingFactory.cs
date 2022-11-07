namespace GOF.Abstract.Factory;

public class StandardOrderPriority : IOrderPriority
{
    public int Priority => 0;
}
public class StandardOrderPercentReduce : IOrderPercentReduce
{
    public decimal PercentReduce => 0;
}
public class StandardShoppingFactory : IShoppingFactory
{
    public IOrderPercentReduce GetPercentReduce()
    {
        return new StandardOrderPercentReduce();
    }

    public IOrderPriority GetOrderPriority()
    {
        return new StandardOrderPriority();
    }
}