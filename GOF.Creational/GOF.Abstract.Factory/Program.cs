using GOF.Abstract.Factory;

var customer = new Customer();

var loyaltyCustomer = new Customer() { Orders = new int[10] };

IShoppingFactory factory = GetFactoryByRule(customer);
IShoppingFactory loyaltyFactory = GetFactoryByRule(loyaltyCustomer);

var shoppingCart = new ShoppingCart(factory);
Console.WriteLine("Shopping card");
shoppingCart.ToOrder();

var loyaltyShoppingCart = new ShoppingCart(loyaltyFactory);
Console.WriteLine("Loyalty Shopping card");
loyaltyShoppingCart.ToOrder();

static IShoppingFactory GetFactoryByRule(Customer c)
{
    if (c.Orders.Length >= 10)
        return new LoyaltyShoppingFactory();
    return new StandardShoppingFactory();
}