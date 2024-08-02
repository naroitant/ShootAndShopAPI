using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Knife : ColdArm
{
    private Knife() : base() { }
    
    public Knife(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        double bladeLengthInInches,
        double overallLengthInInches, 
        Material bladeMaterial,
        Material handleMaterial,
        KnifeStyles knifeStyle,
        BladeStyles bladeStyle) : base(sku, 
        manufacturerNumber, 
        name,
        manufacturer,
        priceInUsd,
        bladeLengthInInches,
        overallLengthInInches, 
        bladeMaterial,
        handleMaterial)
    {
        KnifeStyle = knifeStyle;
        BladeStyle = bladeStyle;
    }

    public KnifeStyles KnifeStyle { get; private set; }
    public BladeStyles BladeStyle { get; private set; }

    public void ChangeSpecs(
        double newBladeLengthInInches,
        double newOverallLengthInInches,
        Material newBladeMaterial,
        Material newHandleMaterial,
        KnifeStyles newKnifeStyle,
        BladeStyles newBladeStyle)
    {
        BladeLengthInInches = newBladeLengthInInches;
        OverallLengthInInches = newOverallLengthInInches;
        BladeMaterial = newBladeMaterial;
        HandleMaterial = newHandleMaterial;
        KnifeStyle = newKnifeStyle;
        BladeStyle = newBladeStyle;
    }
}
