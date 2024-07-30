using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class MagazineTests
{
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var magazine = new Magazine(
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
            30,
            new Material("Polymer"));
        
        // Act
        magazine.ChangeSpecs(
            45,
            new Material("Nylon"));
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Magazine(
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
                    new Material("Nylon"))),
            JsonConvert.SerializeObject(magazine));
    }
}
