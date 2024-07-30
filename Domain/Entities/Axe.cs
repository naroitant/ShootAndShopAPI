namespace ShootAndShopAPI.Domain.Entities;

public class Axe(
    string sku, 
    string manufacturerNumber, 
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    double bladeLengthInInches,
    double overallLengthInInches, 
    Material bladeMaterial,
    Material handleMaterial)
    : ColdArm(
        sku, 
        manufacturerNumber, 
        name,
        manufacturer,
        priceInUsd,
        bladeLengthInInches,
        overallLengthInInches, 
        bladeMaterial,
        handleMaterial) { }
