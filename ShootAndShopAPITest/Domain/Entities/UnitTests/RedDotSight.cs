using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class RedDotSightTests
{
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var redDotSight = new RedDotSight(
            "3620061",
            "798681684274",
            "Sig Sauer Romeo5X Gen II Red-Dot Sight",
            new Manufacturer(name: "Sig Sauer"),
            149.99m,
            new Rifle(
                "1702743",
                "682146830750",
                "Citadel Levtac-92 Rifle 44 Mag. 18 in. M-Lok Black RH",
                new Manufacturer(name: "Citadel"),
                799.00m,
                new Caliber(0.44, Units.Inches),
                new RifleActionType("Lever-Action"),
                16.5,
                8),
            20,
            1,
            2);
        
        // Act
        redDotSight.ChangeSpecs(
            25,
            2,
            1);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new RedDotSight(
                "3620061",
                "798681684274",
                "Sig Sauer Romeo5X Gen II Red-Dot Sight",
                new Manufacturer(name: "Sig Sauer"),
                149.99m,
                new Rifle(
                    "1702743",
                    "682146830750",
                    "Citadel Levtac-92 Rifle 44 Mag. 18 in. M-Lok Black RH",
                    new Manufacturer(name: "Citadel"),
                    799.00m,
                    new Caliber(0.44, Units.Inches),
                    new RifleActionType("Lever-Action"),
                    16.5,
                    8),
                25,
                2,
                1)),
            JsonConvert.SerializeObject(redDotSight));
    }
}
