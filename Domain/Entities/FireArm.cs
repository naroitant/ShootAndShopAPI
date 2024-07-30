using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class FireArm(
    string sku, 
    string manufacturerNumber, 
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Caliber caliber,
    ActionType actionType, 
    double barrelLengthInInches,
    int capacityWithoutChamber)
    : Product(sku, manufacturerNumber, name, manufacturer, priceInUsd)
{
    public Caliber Caliber { get; private set; } = caliber;
    public ActionType ActionType { get; private set; } = actionType;
    public double BarrelLengthInInches { get; private set; } =
        barrelLengthInInches;
    public int CapacityWithoutChamber { get; private set; } =
        capacityWithoutChamber;

    public void ChangeSpecs(
        Caliber newCaliber,
        ActionType newActionType,
        double newBarrelLengthInInches,
        int newCapacityWithoutChamber)
    {
        Caliber = newCaliber;
        ActionType = newActionType;
        BarrelLengthInInches = newBarrelLengthInInches;
        CapacityWithoutChamber = newCapacityWithoutChamber;
    }
}
