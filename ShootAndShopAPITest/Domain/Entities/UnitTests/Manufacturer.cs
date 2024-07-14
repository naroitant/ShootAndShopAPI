using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ManufacturerTests
{
    [Fact]
    public void ShouldChangeManufacturer()
    {
        // Arrange
        var manufacturer = new Manufacturer("CCI Ammunition");
        
        // Act
        manufacturer.Change("Fiocchi Ammunition");
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(
                new Manufacturer("Fiocchi Ammunition")),
            JsonConvert.SerializeObject(manufacturer));
    }
}
