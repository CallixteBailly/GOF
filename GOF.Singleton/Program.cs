// The client code.
using GOF.Singleton;
internal partial class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Console.WriteLine($"If you see the same value, then singleton was reused (yay!)\nIf you see different values, then 2 singletons were created (booo!!)\nRESULT:\n"
            );

        Thread process1 = new(() =>
        {
            TestSingleton("FOO");
        });
        Thread process2 = new(() =>
        {
            TestSingleton("BAR");
        });

        process1.Start();
        process2.Start();

        process1.Join();
        process2.Join();

    }
    public static void TestSingleton(string value)
    {
        Singleton singleton = Singleton.GetInstance(value);
        Console.WriteLine(singleton.Value);
    }
}