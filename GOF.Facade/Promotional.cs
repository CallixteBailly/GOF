namespace GOF.Facade
{
    public static class Promotional
    {
        public static bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine($"{cust.Name} made a purchase of {amount:C} \n");

            if (!Loyalty.HasNoLoyalty(cust))
            {
                return false;
            }
            else if (!Sponsorship.HasNoSponsorship(cust))
            {
                return false;
            }
            else if (!Credit.HasNoCredit(cust))
            {
                return false;
            }

            return true;
        }

        public static class Loyalty
        {
            public static bool HasNoLoyalty(Customer c)
            {
                Console.WriteLine("Check loyalty for " + c.Name);
                return true;
            }
        }

        public static class Credit
        {
            public static bool HasNoCredit(Customer c)
            {
                Console.WriteLine("Check credit for " + c.Name);
                return true;
            }
        }

        public static class Sponsorship
        {
            public static bool HasNoSponsorship(Customer c)
            {
                Console.WriteLine("Check sponsorship for " + c.Name);
                return true;
            }
        }
    }
}
