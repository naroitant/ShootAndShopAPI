namespace ShootAndShopAPI.Domain.Entities;

public class RedDotSight(
    string sku,
    string manufacturerNumber,
    string name,
    Manufacturer manufacturer,
    decimal priceInUsd,
    Product product,
    int objectiveSizeInMillimeters,
    int magnification,
    int dotSizeInMoa)
    : Sight(
        sku,
        manufacturerNumber,
        name,
        manufacturer,
        priceInUsd,
        product,
        objectiveSizeInMillimeters)
{
    public int Magnification { get; private set; } = magnification;
    public int DotSizeInMoa { get; private set; } = dotSizeInMoa;
    
    public void ChangeSpecs(
        int newObjectiveSizeInMillimeters,
        int newMagnification,
        int newDotSizeInMoa)
    {
        ObjectiveSizeInMillimeters = newObjectiveSizeInMillimeters;
        Magnification = newMagnification;
        DotSizeInMoa = newDotSizeInMoa;
    }
}
