using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ColdArmTests
{
    [Fact]
    public void ShouldChangeColdArm()
    {
        // Arrange
        var coldArm = new ColdArm("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            new Category("Knives"),
            7,
            12,
            new Material("Carbon Steel"),
            new Material("Stacked Leather"));
        
        // Act
        coldArm.Change("093674804784",
            "LBR231",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Templar Knives"),
            new Category("Knives"),
            3.5,
            5.5,
            new Material("Black 440C Stainless Steel"),
            new Material("Nylon"));
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new ColdArm(
                "093674804784",
                "LBR231",
                "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
                new Manufacturer("Templar Knives"),
                new Category("Knives"),
                3.5,
                5.5,
                new Material("Black 440C Stainless Steel"),
                new Material("Nylon"))),
            JsonConvert.SerializeObject(coldArm));
    }
}
