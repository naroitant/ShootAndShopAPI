namespace ShootAndShopAPI.Domain.ValueObjects;

public class MagnificationRange(
    int minMagnification, 
    int maxMagnification)
{
    public int MinMagnification { get; private set; } = minMagnification;
    public int MaxMagnification { get; private set; } = maxMagnification;
}
