namespace GOF.Strategy;

internal static class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Context context = new();

        Console.WriteLine("Item: Strategy is set to Descending sorting.");
        context.SetStrategy(new OrderByDescending());
        context.GetItems();

        Console.WriteLine();

        Console.WriteLine("Item: Strategy is set to Ascending sorting.");
        context.SetStrategy(new OrderByAscending());
        context.GetItems();
    }
}