using System.ComponentModel.DataAnnotations.Schema;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Shotgun : FireArm
{
    private Shotgun() : base() { }
    
    public Shotgun(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Caliber caliber,
        ShotgunActionType shotgunActionType, 
        double barrelLengthInInches,
        int capacityWithoutChamber)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            caliber, barrelLengthInInches,
            capacityWithoutChamber) { }
    
    public ShotgunActionType ShotgunActionType { get; private set; }
    public Guid ShotgunActionTypeId { get; private set; }
}
