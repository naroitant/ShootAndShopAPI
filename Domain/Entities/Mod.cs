namespace ShootAndShopAPI.Domain.Entities;

public abstract class Mod(
    string sku,
    string manufacturerNumber,
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Product? product)
    : Product(sku, manufacturerNumber, name, manufacturer, priceInUsd)
{
    public Product? Product { get; private set; } = product;
    public int ProductId { get; private set; }
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
