using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class FireArm : Product
{
    protected FireArm() : base() { }
    
    protected FireArm(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Caliber caliber,
        double barrelLengthInInches,
        int capacityWithoutChamber)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd)
    {
        Caliber = caliber;
        BarrelLengthInInches = barrelLengthInInches;
        CapacityWithoutChamber = capacityWithoutChamber;
    }

    public Caliber Caliber { get; private set; }
    public double BarrelLengthInInches { get; private set; }
    public int CapacityWithoutChamber { get; private set; }

    public void ChangeSpecs(
        Caliber newCaliber,
        double newBarrelLengthInInches,
        int newCapacityWithoutChamber)
    {
        Caliber = newCaliber;
        BarrelLengthInInches = newBarrelLengthInInches;
        CapacityWithoutChamber = newCapacityWithoutChamber;
    }
}
