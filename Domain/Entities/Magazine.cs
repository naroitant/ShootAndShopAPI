namespace ShootAndShopAPI.Domain.Entities;

public class Magazine(
    string sku,
    string manufacturerNumber,
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Product? product,
    int roundCapacity,
    Material material)
    : Mod(sku, manufacturerNumber, name, manufacturer, priceInUsd, product)
{
    public int RoundCapacity { get; private set; } = roundCapacity;
    public Material Material { get; private set; } = material;
    
    public void ChangeSpecs(int newRoundCapacity, Material newMaterial)
    {
        RoundCapacity = newRoundCapacity;
        Material = newMaterial;
    }
}
