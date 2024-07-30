using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ScopeTests
{
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var scope = new Scope(
            "3271220",
            "VTCF231011SW",
            "Vortex Crossfire II 3-9x50 Straight-Wall Rifle Scope",
            new Manufacturer(name: "Vortex"),
            169.99m,
            new Rifle(
                "535711233",
                "048702007125",
                "Winchester XPR Suppressor-Ready Bolt-Action Centerfire Rifle",
                new Manufacturer("Winchester"),
                649.99m,
                new Caliber(0.3, Units.Inches),
                new RifleActionType("Bolt-Action"),
                20.0,
                3),
            50,
            3,
            9,
            3.8,
            32,
            13);
        
        // Act
        scope.ChangeSpecs(
            45,
            4,
            10,
            4.0,
            36,
            14);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Scope(
                "3271220",
                "VTCF231011SW",
                "Vortex Crossfire II 3-9x50 Straight-Wall Rifle Scope",
                new Manufacturer(name: "Vortex"),
                169.99m,
                new Rifle(
                    "535711233",
                    "048702007125",
                    "Winchester XPR Suppressor-Ready Bolt-Action Centerfire Rifle",
                    new Manufacturer("Winchester"),
                    649.99m,
                    new Caliber(0.3, Units.Inches),
                    new RifleActionType("Bolt-Action"),
                    20.0,
                    3),
                45,
                4,
                10,
                4.0,
                36,
                14)),
            JsonConvert.SerializeObject(scope));
    }
}
