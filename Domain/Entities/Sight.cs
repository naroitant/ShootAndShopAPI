namespace ShootAndShopAPI.Domain.Entities;

public abstract class Sight : Mod
{
    protected Sight() : base() { }
    
    protected Sight(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Product product,
        int objectiveSizeInMillimeters)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            product)
    {
        ObjectiveSizeInMillimeters = objectiveSizeInMillimeters;
    }

    public int ObjectiveSizeInMillimeters { get; protected set; }
}
