namespace ShootAndShopAPI.Domain.Entities;

public class Ammo : Product
{
    private Ammo() : base() { }
    
    public Ammo(
        string sku,
        string manufacturerNumber, 
        string name, 
        Manufacturer manufacturer,
        decimal priceInUsd,
        int roundsPerBox, 
        double weightInGrains,
        double velocityInFps)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd)
    {
        RoundsPerBox = roundsPerBox;
        WeightInGrains = weightInGrains;
        VelocityInFps = velocityInFps;
    }

    public int RoundsPerBox { get; private set; }
    public double WeightInGrains { get; private set; }
    public double VelocityInFps { get; private set; }
    
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
