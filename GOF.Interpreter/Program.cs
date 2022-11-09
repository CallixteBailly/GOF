namespace GOF.Interpreter;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args == null)
            throw new ArgumentNullException(nameof(args));

        const string stepOrderCustomer = "ACEFGLILMO";
        Context context = new(stepOrderCustomer);

        // Build the 'parse tree'

        List<Step> tree = new()
        {
            new LoginStep(),
            new AccountStep(),
            new NavStep(),
            new PipeStep()
        };

        // Interpret
        for (int i = 1; i < stepOrderCustomer.Length; i++)
        {
            foreach (Step exp in tree)
            {
                exp.Interpret(context);
            }
        }

        Console.WriteLine("{0} = {1}",
            stepOrderCustomer, context.Output);

        // Wait for user

        _ = Console.ReadKey();
    }
}
