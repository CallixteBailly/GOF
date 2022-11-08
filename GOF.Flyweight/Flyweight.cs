using Newtonsoft.Json;

namespace GOF.Flyweight;

public class Flyweight
{
    private readonly Order _sharedState;

    public Flyweight(Order order)
    {
        _sharedState = order;
    }

    public void Operation(Order uniqueState)
    {
        string s = JsonConvert.SerializeObject(_sharedState);
        string u = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}