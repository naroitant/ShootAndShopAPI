using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Product(string sku, string manufacturerNumber,
    string name, Manufacturer manufacturer, Category category) : BaseEntity
{
    public string Sku { get; protected set; } = sku;
    public string ManufacturerNumber { get; protected set; } =
        manufacturerNumber;
    public string Name { get; protected set; } = name;
    public Category Category { get; protected set; } = category;
    public int QuantityInStock { get; private set; } = 0;
    public List<ProductPrice> PriceHistory { get; protected set; } = [];

    public Manufacturer Manufacturer { get; protected set; } = manufacturer;
    
    public void ChangePrice(decimal newPriceInUsd)
    {
        ProductPrice productPrice = new(DateTimeOffset.Now, newPriceInUsd);
    }
    
    public void Receive(int quantityReceived)
    {
        QuantityInStock += quantityReceived;
    }
    
    public void Spend(int quantitySpent)
    {
        if (QuantityInStock > quantitySpent)
        {
            QuantityInStock -= quantitySpent;
        }
        else
        {
            throw new Exception();
        }
    }
}
