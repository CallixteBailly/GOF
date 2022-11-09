namespace GOF.Memento;
public class Program
{
    public static void Main(string[] args)
    {
        Item i = new()
        {
            HasStock = "On"
        };

        // Store internal state

        ItemMemory im = new()
        {
            Memento = i.CreateMemento()
        };

        // Continue changing

        i.HasStock = "Off";

        // Restore saved state

        i.SetMemento(im.Memento);

        // Wait for user

        Console.ReadKey();
    }
}