namespace GOF.Strategy;

internal class OrderByAscending : IStrategy
{
    public object OrderBy(object data)
    {
        List<Item>? list = data as List<Item>;
        list = list?.OrderBy(s => s.Remaning).ToList();

        return list ?? new object();
    }
}
