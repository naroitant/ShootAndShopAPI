using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ModTests
{
    [Fact]
    public void ShouldAddCompatibleProduct()
    {
        // Arrange
        var magazine = new Magazine(
            "3271220",
            "VTCF231011SW",
            "Vortex Crossfire II 3-9x50 Straight-Wall Rifle Scope",
            new Manufacturer(name: "Vortex"),
            169.99m,
            null,
            30,
            new Material("Polymer"));
        
        // Act
        var rifle = new Rifle(
            "535711233",
            "048702007125",
            "Winchester XPR Suppressor-Ready Bolt-Action Centerfire Rifle",
            new Manufacturer("Winchester"),
            649.99m,
            new Caliber(0.3, Units.Inches),
            new RifleActionType("Bolt-Action"),
            20.0,
            3);
        magazine.AddCompatibleProduct(rifle);
        
        // Assert
        Assert.Equal(
            [rifle],
            magazine.CompatibleProducts);
    }
    
    [Fact]
    public void ShouldRemoveCompatibleProduct()
    {
        // Arrange
        var magazine = new Magazine(
            "3271220",
            "VTCF231011SW",
            "Vortex Crossfire II 3-9x50 Straight-Wall Rifle Scope",
            new Manufacturer(name: "Vortex"),
            169.99m,
            null,
            30,
            new Material("Polymer"));
        
        // Act
        var rifle = new Rifle(
            "535711233",
            "048702007125",
            "Winchester XPR Suppressor-Ready Bolt-Action Centerfire Rifle",
            new Manufacturer("Winchester"),
            649.99m,
            new Caliber(0.3, Units.Inches),
            new RifleActionType("Bolt-Action"),
            20.0,
            3);
        magazine.AddCompatibleProduct(rifle);
        magazine.RemoveCompatibleProduct(rifle);
        
        // Assert
        Assert.Equal(
            [],
            magazine.CompatibleProducts);
    }
    
    [Fact]
    public void ShouldClearCompatibleProduct()
    {
        // Arrange
        var magazine = new Magazine(
            "3271220",
            "VTCF231011SW",
            "Vortex Crossfire II 3-9x50 Straight-Wall Rifle Scope",
            new Manufacturer(name: "Vortex"),
            169.99m,
            null,
            30,
            new Material("Polymer"));
        
        // Act
        var rifle = new Rifle(
            "535711233",
            "048702007125",
            "Winchester XPR Suppressor-Ready Bolt-Action Centerfire Rifle",
            new Manufacturer("Winchester"),
            649.99m,
            new Caliber(0.3, Units.Inches),
            new RifleActionType("Bolt-Action"),
            20.0,
            3);
        var shotgun = new Shotgun(
            "736676169344",
            "16934",
            "Remington 870 Fieldmaster Pump-Action Shotgun",
            new Manufacturer("Remington"),
            499.99m,
            new Caliber(12, Units.Gauges),
            new ShotgunActionType("Pump"),
            28,
            3);
        magazine.AddCompatibleProduct(rifle);
        magazine.AddCompatibleProduct(shotgun);
        magazine.ClearCompatibleProducts();
        
        // Assert
        Assert.Equal(
            [],
            magazine.CompatibleProducts);
    }
    
    [Fact]
    public void ShouldGetPriceForModdedWeapon()
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
        var moddedWeaponPrice = magazine.GetPrice();
        
        // Assert
        Assert.Equal(
            819.98m,
            moddedWeaponPrice);
    }
}
