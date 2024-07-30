namespace ShootAndShopAPI.Domain.Entities;

public abstract class ColdArm(
    string sku, 
    string manufacturerNumber, 
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    double bladeLengthInInches,
    double overallLengthInInches, 
    Material bladeMaterial,
    Material handleMaterial)
    : Product(sku, manufacturerNumber, name, manufacturer, priceInUsd)
{
    public double BladeLengthInInches { get; protected set; } =
        bladeLengthInInches;
    public double OverallLengthInInches { get; protected set; } =
        overallLengthInInches;
    public Material BladeMaterial { get; protected set; } = bladeMaterial;
    public Material HandleMaterial { get; protected set; } = handleMaterial;

    public void ChangeSpecs(
        double newBladeLengthInInches,
        double newOverallLengthInInches,
        Material newBladeMaterial,
        Material newHandleMaterial)
    {
        BladeLengthInInches = newBladeLengthInInches;
        OverallLengthInInches = newOverallLengthInInches;
        BladeMaterial = newBladeMaterial;
        HandleMaterial = newHandleMaterial;
    }
}
