namespace GOF.Builder;

public class Article
{
    public string Name { get; set; } = null!;
    public string Categories { get; set; } = null!;
    public decimal Prices { get; set; }
    public string Details { get; set; } = null!;

    private readonly string _articleType;

    // Constructor
    public Article(string articleType)
    {
        _articleType = articleType;
    }

    public void Show()
    {
        Console.WriteLine("\n---------------------------");
        Console.WriteLine($"Article Type: {_articleType}");
        Console.WriteLine($" Name : {Name}");
        Console.WriteLine($" Categories : {Categories}");
        Console.WriteLine($" Prices: {Prices}");
        Console.WriteLine($" Details : {Details}");
    }
}