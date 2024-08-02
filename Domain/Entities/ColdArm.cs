namespace ShootAndShopAPI.Domain.Entities;

public abstract class ColdArm : Product
{
    protected ColdArm() : base() { }
    
    protected ColdArm(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        double bladeLengthInInches,
        double overallLengthInInches, 
        Material bladeMaterial,
        Material handleMaterial)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd)
    {
        BladeLengthInInches = bladeLengthInInches;
        OverallLengthInInches = overallLengthInInches;
        BladeMaterial = bladeMaterial;
        HandleMaterial = handleMaterial;
    }

    public double BladeLengthInInches { get; protected set; }
    public double OverallLengthInInches { get; protected set; }
    public Material BladeMaterial { get; protected set; }
    public Material HandleMaterial { get; protected set; }

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
