namespace GOF.Flyweight;

public class FlyweightFactory
{
    private readonly List<Tuple<Flyweight, string>> _flyweights = new();

    public FlyweightFactory(params Order[] args)
    {
        foreach (Order elem in args)
        {
            _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), GetKey(elem)));
        }
    }

    // Returns a Flyweight's string hash for a given state.
    public static string GetKey(Order key)
    {
        List<string> elements = new()
        {
            key.Title,
            key.Category
        };

        if (key.Customer != null && key.UniqueId != null)
        {
            elements.Add(key.UniqueId);
            elements.Add(key.Customer);
        }

        elements.Sort();

        return string.Join("_", elements);
    }

    public IEnumerable<Tuple<Flyweight, string>> GetFlyweights()
    {
        return _flyweights;
    }


    public Flyweight GetFlyweight(Order sharedState, IEnumerable<Tuple<Flyweight, string>> flyweights)
    {
        string key = GetKey(sharedState);

        if (!flyweights.Any(t => t.Item2 == key))
        {
            Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
            _flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
        }
        else
        {
            Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
        }
        return flyweights.First(t => t.Item2 == key).Item1 ?? new Flyweight(sharedState);
    }

    public void ListFlyweights()
    {
        int count = _flyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (Tuple<Flyweight, string> flyweight in _flyweights)
        {
            Console.WriteLine(flyweight.Item2);
        }
    }
}