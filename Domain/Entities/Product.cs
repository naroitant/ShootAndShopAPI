using Domain.Common;

namespace Domain.Entities;

public abstract class Product(string sku, string manufacturerNumber,
    string name, Manufacturer manufacturer) : BaseEntity
{
    public string Sku { get; protected set; } = sku;
    public string ManufacturerNumber { get; protected set; } =
        manufacturerNumber;
    public string Name { get; protected set; } = name;
    public int QuantityInStock { get; protected set; }
    public List<ProductPrice> PriceHistory { get; protected set; } = [];

    public Manufacturer Manufacturer { get; protected set; } = manufacturer;
    
    public void DecreaseQuantityInStock(int quantityReceived)
    {
        QuantityInStock -= quantityReceived;
    }
    
    public void IncreaseQuantityInStock(int quantitySpent)
    {
        QuantityInStock += quantitySpent;
    }
}
