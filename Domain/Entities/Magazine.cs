namespace ShootAndShopAPI.Domain.Entities;

public class Magazine : Mod
{
    private Magazine() : base() { }
    
    public Magazine(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Product? product,
        int roundCapacity,
        Material material)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            product)
    {
        RoundCapacity = roundCapacity;
        Material = material;
    }

    public int RoundCapacity { get; private set; }
    public Material Material { get; private set; }
    
    public void ChangeSpecs(int newRoundCapacity, Material newMaterial)
    {
        RoundCapacity = newRoundCapacity;
        Material = newMaterial;
    }
}
