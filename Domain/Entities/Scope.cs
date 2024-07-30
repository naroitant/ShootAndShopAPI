using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Scope(
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
    : Sight(sku, manufacturerNumber, name, manufacturer, priceInUsd, product,
        objectiveSizeInMillimeters)
{
    public MagnificationRange MagnificationRange { get; private set; } =
        new(minMagnification, maxMagnification);
    public double EyeReliefInInches { get; private set; } = eyeReliefInInches;
    public FovRange FovRange { get; private set; } = 
        new(fovInFeetAtZeroYards, fovInFeetAtOneHundredYards);
    
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
