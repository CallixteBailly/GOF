using GOF.Factory.Method;

abstract class ProductDescription
{
    public IList<Section> Sections { get; set; } = new List<Section>();

    public ProductDescription()
    {
        CreateProductDescription();
    }

    // Factory Method
    public abstract void CreateProductDescription();
}