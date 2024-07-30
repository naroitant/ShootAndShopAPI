namespace ShootAndShopAPI.Domain.ValueObjects;

public class FovRange(
    double fovInFeetAtZeroYards, 
    double fovInFeetAtOneHundredYards)
{
    public double FovInFeetAtZeroYards { get; private set; } =
        fovInFeetAtZeroYards;
    public double FovInFeetAtOneHundredYards { get; private set; } =
        fovInFeetAtOneHundredYards;
}
