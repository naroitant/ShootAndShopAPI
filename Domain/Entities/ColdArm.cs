namespace Domain.Entities;

public class ColdArm(string sku, string manufacturerNumber, string name,
    decimal bladeLengthInInches, decimal overallLengthInInches,
    Manufacturer manufacturer) : Product(sku, manufacturerNumber, name,
    manufacturer)
{
    public decimal BladeLengthInInches { get; private set; } =
        bladeLengthInInches;
    public decimal OverallLengthInInches { get; private set; } =
        overallLengthInInches;

    public void Update(string sku, string manufacturerNumber, string name,
        int quantityInStock, decimal bladeLengthInInches,
        decimal overallLengthInInches)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        QuantityInStock = quantityInStock;
        BladeLengthInInches = bladeLengthInInches;
        OverallLengthInInches = overallLengthInInches;
    }
}
