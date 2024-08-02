namespace ShootAndShopAPI.Domain.Entities;

public abstract class Mod : Product
{
    protected Mod() : base() { }
    
    protected Mod(string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Product? product)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd)
    {
        Product = product;
    }

    public Product? Product { get; private set; }
    public Guid ProductId { get; private set; }
    public List<Product> CompatibleProducts { get; private set; } = [];

    public void AddCompatibleProduct(Product newCompatibleProduct)
    {
        CompatibleProducts.Add(newCompatibleProduct);
    }

    public void RemoveCompatibleProduct(Product compatibleProduct)
    {
        CompatibleProducts.Remove(compatibleProduct);
    }

    public void ClearCompatibleProducts()
    {
        CompatibleProducts.Clear();
    }
    
    public decimal GetPrice()
    {
        if (Product != null)
        {
            return PriceInUsd + Product.PriceInUsd;
        }
        else
        {
            return PriceInUsd;
        }
    }
}
