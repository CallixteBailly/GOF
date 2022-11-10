namespace GOF.Strategy;

internal class Context
{
    private IStrategy? _strategy;

    public Context()
    { }

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void GetItems()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
        object? result = _strategy?.OrderBy(new List<Item>
        {
            new Item()
            {
                Title = "Iphone 14 Pro Max",
                Remaning = 3
            },
            new Item()
            {
                Title = "Ebook Harry potter",
                Remaning = 2
            },
            new Item()
            {
                Title = "Bose Q514",
                Remaning = 1
            }
        });

        string resultStr = string.Empty;
        if(result == null)
            return;

        foreach (Item item in (List<Item>)result)
        {
            resultStr += $"-{item.Title} => {item.Remaning}\n";
        }

        Console.WriteLine(resultStr);
    }
}
