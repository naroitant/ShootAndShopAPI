namespace ShootAndShopAPI.Domain.Entities;

public class ColdArm(string sku, string manufacturerNumber, string name,
    Manufacturer manufacturer, Category category, double bladeLengthInInches,
    double overallLengthInInches, Material bladeMaterial,
    Material handleMaterial) : Product(sku, manufacturerNumber, name,
    manufacturer, category)
{
    public double BladeLengthInInches { get; private set; } =
        bladeLengthInInches;
    public double OverallLengthInInches { get; private set; } =
        overallLengthInInches;
    public Material BladeMaterial { get; private set; } = bladeMaterial;
    public Material HandleMaterial { get; private set; } = handleMaterial;

    public void Change(string sku, string manufacturerNumber, string name,
        Manufacturer manufacturer, Category category,
        double bladeLengthInInches, double overallLengthInInches,
        Material bladeMaterial, Material handleMaterial)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        Manufacturer = manufacturer;
        Category = category;
        BladeLengthInInches = bladeLengthInInches;
        OverallLengthInInches = overallLengthInInches;
        BladeMaterial = bladeMaterial;
        HandleMaterial = handleMaterial;
    }
}
