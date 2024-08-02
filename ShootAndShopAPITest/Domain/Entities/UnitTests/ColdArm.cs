using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ColdArmTests
{
    public class ColdArmTest(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd,
        double bladeLengthInInches,
        double overallLengthInInches, 
        Material bladeMaterial,
        Material handleMaterial)
        : ColdArm(sku, manufacturerNumber, name, manufacturer, priceInUsd,
            bladeLengthInInches, overallLengthInInches, bladeMaterial,
            handleMaterial) { }
    
    [Fact]
    public void ShouldChangeSpecs()
    {
        // Arrange
        var coldArm = new ColdArmTest("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            86.29m,
            7,
            12,
            new Material("Carbon Steel"),
            new Material("Stacked Leather"));
        
        // Act
        coldArm.ChangeSpecs(
            3.5,
            5.5,
            new Material("Black 440C Stainless Steel"),
            new Material("Nylon"));
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new ColdArmTest(
                "617717212178",
                "1217",
                "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
                new Manufacturer("Ka-Bar"),
                86.29m,
                3.5,
                5.5,
                new Material("Black 440C Stainless Steel"),
                new Material("Nylon"))),
            JsonConvert.SerializeObject(coldArm));
    }
}
