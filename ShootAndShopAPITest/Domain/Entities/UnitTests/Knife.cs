using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class KnifeTests
{
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var knife = new Knife("2203766",
            "BUCK0863BRSB",
            "Buck 863 Selkirk Knife 0863BRS-B, survival knife",
            new Manufacturer("Buck"),
            86.29m,
            4.625,
            7.955,
            new Material("Martensitic 420 Stainless Steel"),
            new Material("Micarta"),
            KnifeStyles.Edc,
            BladeStyles.DropPoint);
        
        // Act
        knife.ChangeSpecs(
            5.250,
            8.250,
            new Material("Black 440C Stainless Steel"),
            new Material("Nylon"),
            KnifeStyles.Fixed,
            BladeStyles.ClipPoint);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Knife("2203766",
                "BUCK0863BRSB",
                "Buck 863 Selkirk Knife 0863BRS-B, survival knife",
                new Manufacturer("Buck"),
                86.29m,
                5.250,
                8.250,
                new Material("Black 440C Stainless Steel"),
                new Material("Nylon"),
                KnifeStyles.Fixed,
                BladeStyles.ClipPoint)),
            JsonConvert.SerializeObject(knife));
    }
}
