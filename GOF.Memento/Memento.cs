namespace GOF.Memento;

public class Memento
{
    public string HasStock { get; }

    public Memento(string hasSotck)
    {
        HasStock = hasSotck;
    }
}
