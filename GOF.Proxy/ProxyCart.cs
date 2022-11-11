namespace GOF.Proxy;
public class ProxyCart : Cart
{
    private CartAPI? _cart;

    public override void CreateShoppingCart()
    {
        (_cart ??= new CartAPI()).CreateShoppingCart();
    }
}
