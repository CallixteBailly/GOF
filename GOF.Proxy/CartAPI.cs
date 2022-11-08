namespace GOF.Proxy;

public class CartAPI : Cart
{
    public override void CreateShoppingCart()
    {
        Console.WriteLine("Called CartAPI.CreateShoppingCart()");
    }
}

