namespace ShootAndShopAPI.Domain.Entities;

public class Axe : ColdArm
{
    private Axe() : base() { }
    
    public Axe(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        double bladeLengthInInches,
        double overallLengthInInches, 
        Material bladeMaterial,
        Material handleMaterial)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd, 
            bladeLengthInInches, overallLengthInInches, bladeMaterial, 
            handleMaterial) { }
}
