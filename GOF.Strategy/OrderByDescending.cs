namespace GOF.Strategy;

internal class OrderByDescending : IStrategy
{
    public object OrderBy(object data)
    {
        List<Item>? list = data as List<Item>;
        return list?
            .OrderByDescending(s => s.Remaning)
            .ToList() ?? new object();
    }
}
