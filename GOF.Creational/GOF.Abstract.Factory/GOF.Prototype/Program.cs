namespace GOF.Prototype;
internal static class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Customer c1 = new()
        {
            Age = 42,
            BirthDate = Convert.ToDateTime("1977-01-01"),
            Name = "Jack Daniels",
            Address = new Address()
            {
                Address1 = "republique",
                Address2 = "157 bat",
                City = "Nanterre",
                Country = "France"
            }
        };

        // Perform a shallow copy of c1 and assign it to c2.
        Customer c2 = c1.ShallowCopy();
        // Make a deep copy of c1 and assign it to c3.
        Customer c3 = c1.DeepCopy();

        // Display values of c1, c2 and c3.
        Console.WriteLine("Original values of c1, c2, c3:");
        Console.WriteLine("c1 instance values: \n");
        DisplayValues(c1);
        Console.WriteLine("c2 instance values: \n");
        DisplayValues(c2);
        Console.WriteLine("c3 instance values: \n");
        DisplayValues(c3);

        // Change the value of c1 croperties and display the values of c1,
        // c2 and c3.
        c1.Age = 32;
        c1.BirthDate = Convert.ToDateTime("1900-01-01");
        c1.Name = "Frank";
        c1.Address.Address1 = "Paris";
        c1.Address.Address2 = "avion 113";
        c1.Address.City = "Versaille";
        c1.Address.Country = "France";

        Console.WriteLine("\n Values of c1, c2 and c3 after changes to c1:");
        Console.WriteLine("c1 instance values: \n");
        DisplayValues(c1);
        Console.WriteLine("c2 instance values (reference values have changed): \n");
        DisplayValues(c2);
        Console.WriteLine("c3 instance values (everything was kept the same): \n");
        DisplayValues(c3);
    }
    public static void DisplayValues(Customer c)
    {
        Console.WriteLine($"Name: {c.Name},\nAge: {c.Age},\nBirthDate: {c.BirthDate}");
        Console.WriteLine($"ID#: {c.Address}");
    }
}