using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Scope : Sight
{
    private Scope() : base() { }
    
    public Scope(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Product product,
        int objectiveSizeInMillimeters,
        int minMagnification,
        int maxMagnification,
        double eyeReliefInInches,
        double fovInFeetAtZeroYards,
        double fovInFeetAtOneHundredYards)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            product, objectiveSizeInMillimeters)
    {
        MagnificationRange = new MagnificationRange(minMagnification,
            maxMagnification);
        EyeReliefInInches = eyeReliefInInches;
        FovRange = new FovRange(fovInFeetAtZeroYards,
            fovInFeetAtOneHundredYards);
    }

    public MagnificationRange MagnificationRange { get; private set; }
    public double EyeReliefInInches { get; private set; }
    public FovRange FovRange { get; private set; }
    
    public void ChangeSpecs(
        int newObjectiveSizeInMillimeters,
        int newMinMagnification,
        int newMaxMagnification,
        double newEyeReliefInInches,
        double newFovInFeetAtZeroYards,
        double newFovInFeetAtOneHundredYards)
    {
        ObjectiveSizeInMillimeters = newObjectiveSizeInMillimeters;
        MagnificationRange = new MagnificationRange(newMinMagnification,
            newMaxMagnification);
        EyeReliefInInches = newEyeReliefInInches;
        FovRange = new FovRange(newFovInFeetAtZeroYards,
            newFovInFeetAtOneHundredYards);
    }
}
