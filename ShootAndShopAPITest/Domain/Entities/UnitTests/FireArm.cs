using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class FireArmTests
{
    public class FireArmTest(
        string sku,
        string manufacturerNumber,
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        Caliber caliber,
        ActionType actionType,
        double barrelLengthInInches,
        int capacityWithoutChamber)
        : FireArm(
            sku,
            manufacturerNumber,
            name,
            manufacturer,
            priceInUsd,
            caliber,
            actionType,
            barrelLengthInInches,
            capacityWithoutChamber) { }
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var fireArm = new FireArmTest(
            "736676169344",
            "16934",
            "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
            new Manufacturer("Ruger"),
            799.00m,
            new Caliber(9, Units.Millimeters),
            new RifleActionType("Semi-Auto"),
            16.1,
            17);
        
        // Act
        fireArm.ChangeSpecs(
            new Caliber(0.308, Units.Inches),
            new RifleActionType("Bolt"),
            22,
            4);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new FireArmTest(
                "736676169344",
                "16934",
                "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
                new Manufacturer("Ruger"),
                799.00m,
                new Caliber(0.308, Units.Inches),
                new RifleActionType("Bolt"),
                22,
                4)),
            JsonConvert.SerializeObject(fireArm));
    }
}
