namespace ShootAndShopAPI.Domain.Entities;

public abstract class Sight(
    string sku,
    string manufacturerNumber,
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Product product,
    int objectiveSizeInMillimeters)
    : Mod(sku, manufacturerNumber, name, manufacturer, priceInUsd, product)
{
    public int ObjectiveSizeInMillimeters { get; protected set; } = 
        objectiveSizeInMillimeters;
}
