namespace GOF.Memento;

public class Item
{
    private string? hasStock;

    public string HasStock
    {
        get => hasStock ?? string.Empty;
        set
        {
            hasStock = value;
            Console.WriteLine("State = " + hasStock);
        }
    }

    public Memento CreateMemento()
    {
        return new Memento(HasStock);
    }

    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Restoring state...");
        HasStock = memento.HasStock;
    }
}

