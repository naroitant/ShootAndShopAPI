namespace ShootAndShopAPI.Domain.Entities;

public class RedDotSight : Sight
{
    private RedDotSight() : base() { }
    
    public RedDotSight(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Product product,
        int objectiveSizeInMillimeters,
        int magnification,
        int dotSizeInMoa)
        : base(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            product, objectiveSizeInMillimeters)
    {
        Magnification = magnification;
        DotSizeInMoa = dotSizeInMoa;
    }

    public int Magnification { get; private set; }
    public int DotSizeInMoa { get; private set; }
    
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
