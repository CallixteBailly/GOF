namespace GOF.Memento;

public class Item
{
    private string? _hasStock;

    public string HasStock
    {
        get => _hasStock ?? string.Empty;
        set
        {
            _hasStock = value;
            Console.WriteLine("State = " + _hasStock);
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