using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class AmmoTests
{
    [Fact]
    public void ShouldChangeAmmo()
    {
        // Arrange
        var ammo = new Ammo(
            "757750308152",
            "DPX762X39123",
            "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
            new Category("Handgun Rounds"),
            20,
            123,
            2300,
            new Manufacturer(name: "Con-Bon"));
        
        // Act
        ammo.Change(
            "090255902426",
            "90242",
            "Hornady Custom 9mm 124gr, Jacketed Hollow Point XTP 25rd Box",
            new Category("Centerfire Handgun Rounds"),
            25,
            124,
            1110,
            new Manufacturer(name: "Hornady Ammunition"));
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Ammo(
                "090255902426",
                "90242",
                "Hornady Custom 9mm 124gr, Jacketed Hollow Point XTP 25rd Box",
                new Category("Centerfire Handgun Rounds"),
                25,
                124,
                1110,
                new Manufacturer(name: "Hornady Ammunition"))),
            JsonConvert.SerializeObject(ammo));
    }
}
