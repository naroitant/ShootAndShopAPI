using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ProductTests
{
    private class ProductTest(
        string sku, 
        string manufacturerNumber, 
        string name,
        Manufacturer manufacturer,
        decimal priceInUsd)
        : Product(sku, manufacturerNumber, name, manufacturer, priceInUsd) { }
    
    [Fact]
    public void ShouldChangeCommonInfo()
    {
        // Arrange
        var product = new ProductTest("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            86.29m);
        
        // Act
        product.ChangeCommonInfo(
            "2203766",
            "BUCK0863BRSB",
            "Buck 863 Selkirk Knife 0863BRS-B, survival knife",
            new Manufacturer("Buck"));
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new ProductTest(
                "2203766",
                "BUCK0863BRSB",
                "Buck 863 Selkirk Knife 0863BRS-B, survival knife",
                new Manufacturer("Buck"),
                86.29m)),
            JsonConvert.SerializeObject(product));
    }

    [Fact]
    public void ShouldChangePrice()
    {
        // Arrange
        var product = new ProductTest("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            86.29m);
        
        // Act
        product.ChangePrice(99.99m);
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new ProductTest(
                "617717212178",
                "1217",
                "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
                new Manufacturer("Ka-Bar"),
                99.99m)),
            JsonConvert.SerializeObject(product));
    }
    
    [Fact]
    public void ShouldReceiveQuantityInStock()
    {
        // Arrange
        var product = new ProductTest("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            86.29m);
        
        // Act
        product.Receive(10);
        
        // Assert
        Assert.Equal(
            10,
            product.QuantityInStock);
    }
    
    [Fact]
    public void ShouldSpendQuantityInStock()
    {
        // Arrange
        var product = new ProductTest("617717212178",
            "1217",
            "Kabar USMC Fight 7\" 1095 CroVan Straight Leather Handle & Sheath",
            new Manufacturer("Ka-Bar"),
            86.29m);
        
        // Act
        product.Receive(10);
        product.Spend(10);
        
        // Assert
        Assert.Equal(
            0,
            product.QuantityInStock);
    }
}
