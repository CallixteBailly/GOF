namespace GOF.Proxy;
public class ProxyCart : Cart
{
    private CartAPI? cart;

    public override void CreateShoppingCart()
    {
        if (cart == null)
        {
            cart = new CartAPI();
        }
        cart.CreateShoppingCart();
    }
}

