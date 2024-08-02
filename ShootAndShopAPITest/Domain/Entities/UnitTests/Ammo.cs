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
            new Manufacturer(name: "Con-Bon"),
            37.99m,
            20,
            123,
            2300);
        
        // Act
        ammo.ChangeSpecs(
            25,
            124,
            1110);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Ammo(
                "757750308152",
                "DPX762X39123",
                "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
                new Manufacturer(name: "Con-Bon"),
                37.99m,
                25,
                124,
                1110)),
            JsonConvert.SerializeObject(ammo));
    }
    
    [Fact]
    public void ShouldAddToQuantityInStock()
    {
        // Arrange
        var ammo = new Ammo(
            "757750308152",
            "DPX762X39123",
            "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
            new Manufacturer(name: "Con-Bon"),
            37.99m,
            20,
            123,
            2300);
        
        // Act
        ammo.Receive(10);
        
        // Assert
        Assert.Equal(10, ammo.QuantityInStock);
    }
    
    [Fact]
    public void ShouldReduceQuantityInStock()
    {
        // Arrange
        var ammo = new Ammo(
            "757750308152",
            "DPX762X39123",
            "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
            new Manufacturer(name: "Con-Bon"),
            37.99m,
            20,
            123,
            2300);
        ammo.Receive(10);
        
        // Act
        ammo.Spend(5);
        
        // Assert
        Assert.Equal(5, ammo.QuantityInStock);
    }
    
    [Fact]
    public void ShouldPreventQuantityInStockFromBeingNegative()
    {
        // Arrange
        var ammo = new Ammo(
            "757750308152",
            "DPX762X39123",
            "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
            new Manufacturer(name: "Con-Bon"),
            37.99m,
            20,
            123,
            2300);
        
        // Act
        var exception = Record.Exception(() => ammo.Spend(5));
        
        // Assert
        Assert.IsType<Exception>(exception);
    }
}
