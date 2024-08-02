using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Rifle : FireArm
{
    private Rifle() { }
    
    public Rifle(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Caliber caliber,
        RifleActionType rifleActionType, 
        double barrelLengthInInches,
        int capacityWithoutChamber)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            caliber, barrelLengthInInches,
            capacityWithoutChamber) { }
    
    public RifleActionType RifleActionType { get; private set; }
    public Guid RifleActionTypeId { get; private set; }
}
