namespace GOF.Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            // Facade

            Promotional promo = new();

            // Evaluate mortgage eligibility for customer

            Customer customer = new("Bailly Kality");
            bool eligible = promo.IsEligible(customer, 100);

            Console.WriteLine("\n" + customer.Name +
                    " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            _ = Console.ReadKey();
        }
    }
}
