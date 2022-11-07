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
            result.Append(nameof(Address1)).Append(" = ").Append(Address1).AppendLine(";");
            result.Append(nameof(Address2)).Append(" = ").Append(Address2).AppendLine(";");
            result.Append(nameof(Country)).Append(" = ").Append(Country).AppendLine(";");
            result.Append(nameof(City)).Append(" = ").Append(City).AppendLine(";");
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