using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class FireArm(string sku, string manufacturerNumber, string name,
    Manufacturer manufacturer, Category category, Caliber caliber,
    ActionType actionType, double barrelLengthInInches,
    int capacityWithoutChamber) : Product(sku, manufacturerNumber, name,
    manufacturer, category)
{
    public Caliber Caliber { get; private set; } = caliber;
    public ActionType ActionType { get; private set; } = actionType;
    public double BarrelLengthInInches { get; private set; } =
        barrelLengthInInches;
    public int CapacityWithoutChamber { get; private set; } =
        capacityWithoutChamber;

    public void Change(string sku, string manufacturerNumber, string name,
        Manufacturer manufacturer, Category category, Caliber caliber,
        ActionType actionType, double barrelLengthInInches,
        int capacityWithoutChamber)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        Manufacturer = manufacturer;
        Category = category;
        Caliber = caliber;
        ActionType = actionType;
        BarrelLengthInInches = barrelLengthInInches;
        CapacityWithoutChamber = capacityWithoutChamber;
    }
}
