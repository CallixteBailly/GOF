namespace GOF.Composite;
internal static class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        // Create a tree structure
        Order order = new("singleOrder");
        order.Add(new Cart("Cart 1"));
        Order mOrder = new("MultiOrder");
        mOrder.Add(new Cart("Cart M1"));
        mOrder.Add(new Cart("Cart M2"));
        order.Add(mOrder);
        // Add and remove a leaf
        order.Add(new Cart("Cart 2"));

        Cart leaf = new("Cart 3");
        order.Add(leaf);
        order.Remove(leaf);
        // Recursively display tree
        order.Display(1);
        // Wait for user
        _ = Console.ReadKey();
    }
}