namespace Domain.Entities;

public class FireArm(string sku, string manufacturerNumber, string name,
    decimal caliber, decimal barrelLengthInInches, int capacity,
    Manufacturer manufacturer) : Product(sku, manufacturerNumber, name,
    manufacturer)
{
    public decimal Caliber { get; private set; } = caliber;
    public decimal BarrelLengthInInches { get; private set; } =
        barrelLengthInInches;
    public int Capacity { get; private set; } = capacity;

    public void Update(string sku, string manufacturerNumber, string name,
        int quantityInStock, decimal caliber,
        decimal barrelLengthInInches, int capacity)
    {
        Sku = sku;
        ManufacturerNumber = manufacturerNumber;
        Name = name;
        QuantityInStock = quantityInStock;
        Caliber = caliber;
        BarrelLengthInInches = barrelLengthInInches;
        Capacity = capacity;
    }
}
