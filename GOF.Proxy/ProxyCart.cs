namespace GOF.Proxy;
public class ProxyCart : Cart
{
    private CartAPI? cart;

    public override void CreateShoppingCart()
    {
        (cart ??= new CartAPI()).CreateShoppingCart();
    }
}
