namespace GOF.Facade
{
    public partial class Promotional
    {
        private readonly Loyalty loyalty = new();
        private readonly Sponsorship sponsorship = new();
        private readonly Credit credit = new();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine($"{cust.Name} made a purchase of {amount:C} \n");

            bool eligible = true;

            // Check creditworthyness of applicant

            if (!loyalty.HasNoLoyalty(cust, amount))
            {
                eligible = false;
            }
            else if (!sponsorship.HasNoSponsorship(cust))
            {
                eligible = false;
            }
            else if (!credit.HasNoCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }

        public class Loyalty
        {
            public bool HasNoLoyalty(Customer c, int amount)
            {
                Console.WriteLine("Check loyalty for " + c.Name);
                return true;
            }
        }

        public class Credit
        {
            public bool HasNoCredit(Customer c)
            {
                Console.WriteLine("Check credit for " + c.Name);
                return true;
            }
        }

        public class Sponsorship
        {
            public bool HasNoSponsorship(Customer c)
            {
                Console.WriteLine("Check sponsorship for " + c.Name);
                return true;
            }
        }
    }
}
