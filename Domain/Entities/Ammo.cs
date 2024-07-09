namespace Domain.Entities;

public class Ammo(string sku, string manufacturerNumber, string name,
    int roundsPerBox, decimal weightInGrains, decimal velocityInFps,
    Manufacturer manufacturer) : Product(sku, manufacturerNumber, name,
    manufacturer)
{
    public int RoundsPerBox { get; private set; } = roundsPerBox;
    public decimal WeightInGrains { get; private set; } = weightInGrains;
    public decimal VelocityInFps { get; private set; } = velocityInFps;

    public void Update(string sku, string manufacturerNumber, string name,
        int quantityInStock, int roundsPerBox, decimal weightInGrains,
        decimal velocityInFps)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        QuantityInStock = quantityInStock;
        RoundsPerBox = roundsPerBox;
        WeightInGrains = weightInGrains;
        VelocityInFps = velocityInFps;
    }
}
