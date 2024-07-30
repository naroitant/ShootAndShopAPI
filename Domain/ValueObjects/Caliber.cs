namespace ShootAndShopAPI.Domain.ValueObjects;

public class Caliber(
    double amount, 
    Units unit)
{
    public double Amount { get; private set; } = amount;
    public Units Unit { get; private set; } = unit;
}
