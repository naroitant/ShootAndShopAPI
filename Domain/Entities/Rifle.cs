using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Rifle(
    string sku, 
    string manufacturerNumber, 
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Caliber caliber,
    RifleActionType rifleActionType, 
    double barrelLengthInInches,
    int capacityWithoutChamber)
    : FireArm(
        sku, 
        manufacturerNumber, 
        name,
        manufacturer,
        priceInUsd,
        caliber,
        rifleActionType, 
        barrelLengthInInches,
        capacityWithoutChamber) { }
