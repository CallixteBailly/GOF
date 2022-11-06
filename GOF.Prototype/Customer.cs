using System.Text;

namespace GOF.Prototype
{
    public class Address
    {
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine($"{nameof(Address1)} = {Address1};");
            result.AppendLine($"{nameof(Address2)} = {Address2};");
            result.AppendLine($"{nameof(Country)} = {Country};");
            result.AppendLine($"{nameof(City)} = {City};");
            return result.ToString();
        }

    }

    public class Customer
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid Id { get; set; }
        public Address Address { get; set; } = null!;

        public Customer ShallowCopy()
        {
            return (Customer)this.MemberwiseClone();
        }

        public Customer DeepCopy()
        {
            Customer clone = (Customer)this.MemberwiseClone();
            clone.Address = new Address()
            {
                Address1 = Address.Address1,
                Address2 = Address.Address2,
                City = Address.City,
                Country = Address.Country,
            };
            return clone;
        }
    }
}