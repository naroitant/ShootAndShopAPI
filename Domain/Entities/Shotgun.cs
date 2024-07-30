using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Shotgun(
    string sku, 
    string manufacturerNumber, 
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Caliber caliber,
    ShotgunActionType shotgunActionType, 
    double barrelLengthInInches,
    int capacityWithoutChamber)
    : FireArm(
        sku, 
        manufacturerNumber, 
        name,
        manufacturer,
        priceInUsd,
        caliber,
        shotgunActionType, 
        barrelLengthInInches,
        capacityWithoutChamber) { }
