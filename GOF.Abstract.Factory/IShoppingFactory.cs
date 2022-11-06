namespace GOF.Abstract.Factory;
public interface IShoppingFactory
{
    IOrderPercentReduce GetPercentReduce();
    IOrderPriority GetOrderPriority();
}
public interface IOrderPriority
{
    int Priority { get; }
}
public interface IOrderPercentReduce
{
    decimal PercentReduce { get; }
}