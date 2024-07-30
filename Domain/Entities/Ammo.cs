namespace ShootAndShopAPI.Domain.Entities;

public class Ammo(
    string sku,
    string manufacturerNumber, 
    string name, 
    Manufacturer manufacturer,
    decimal priceInUsd,
    int roundsPerBox, 
    double weightInGrains,
    double velocityInFps)
    : Product(sku, manufacturerNumber, name, manufacturer, priceInUsd)
{
    public int RoundsPerBox { get; private set; } = roundsPerBox;
    public double WeightInGrains { get; private set; } = weightInGrains;
    public double VelocityInFps { get; private set; } = velocityInFps;
    
    public void ChangeSpecs(
        int roundsPerBox, 
        double weightInGrains,
        double velocityInFps)
    {
        RoundsPerBox = roundsPerBox;
        WeightInGrains = weightInGrains;
        VelocityInFps = velocityInFps;
    }
}
