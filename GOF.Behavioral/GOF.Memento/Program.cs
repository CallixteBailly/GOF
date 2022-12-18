namespace GOF.Memento;
public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
        {
            throw new ArgumentNullException(nameof(args));
        }

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

        _ = Console.ReadKey();
    }
}