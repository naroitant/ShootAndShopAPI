namespace ShootAndShopAPI.Domain.ValueObjects;

public class Caliber(double amount, Unit unit)
{
    public double Amount { get; private set; } = amount;
    public Unit Unit { get; private set; } = unit;
}
