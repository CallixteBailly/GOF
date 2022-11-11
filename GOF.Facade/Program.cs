namespace GOF.Facade
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Customer customer = new("Bailly Kality");
            bool eligible = Promotional.IsEligible(customer, 100);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

            _ = Console.ReadKey();
        }
    }
}
