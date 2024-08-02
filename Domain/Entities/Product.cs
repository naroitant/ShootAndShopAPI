using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Product : BaseEntity
{
    protected Product() { }
    
    protected Product(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        Manufacturer = manufacturer;
        PriceInUsd = priceInUsd;
    }

    public string Sku { get; protected set; }
    public string ManufacturerNumber { get; protected set; }
    public string Name { get; protected set; }
    public Manufacturer Manufacturer { get; protected set; }
    public Guid ManufacturerId { get; protected set; }
    public decimal PriceInUsd { get; protected set; }
    public int QuantityInStock { get; private set; } = 0;
    public List<ProductPrice> PriceHistory { get; protected set; } = [];
    public List<Item> Items { get; protected set; } = [];
    
    public void ChangeCommonInfo(
        string newSku,
        string newManufacturerNumber,
        string newName,
        Manufacturer newManufacturer)
    {
        Sku = newSku;
        ManufacturerNumber = newManufacturerNumber;
        Name = newName;
        Manufacturer = newManufacturer;
    }
    
    public void ChangePrice(decimal newPriceInUsd)
    {
        PriceInUsd = newPriceInUsd;
        var newProductPrice = new ProductPrice(
            DateTimeOffset.Now,
            newPriceInUsd,
            this);
        PriceHistory.Add(newProductPrice);
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
