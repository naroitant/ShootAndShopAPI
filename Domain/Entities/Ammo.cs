namespace ShootAndShopAPI.Domain.Entities;

public class Ammo(string sku, string manufacturerNumber, string name,
    Category category, int roundsPerBox, decimal weightInGrains,
    decimal velocityInFps, Manufacturer manufacturer) : Product(sku,
    manufacturerNumber, name, manufacturer, category)
{
    public int RoundsPerBox { get; private set; } = roundsPerBox;
    public decimal WeightInGrains { get; private set; } = weightInGrains;
    public decimal VelocityInFps { get; private set; } = velocityInFps;

    public void Change(string sku, string manufacturerNumber, string name,
        Category category, int roundsPerBox, decimal weightInGrains,
        decimal velocityInFps, Manufacturer manufacturer)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        Category = category;
        RoundsPerBox = roundsPerBox;
        WeightInGrains = weightInGrains;
        VelocityInFps = velocityInFps;
        Manufacturer = manufacturer;
    }
}
