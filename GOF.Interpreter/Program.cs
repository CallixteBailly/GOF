namespace GOF.Interpreter;

public class Program
{
    public static void Main(string[] args)
    {
        string stepOrderCustomer = "ACEFGLILMO";
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
        for (int i = 1; i < stepOrderCustomer.Count(); i++)
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
