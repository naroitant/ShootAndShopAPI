using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class MaterialTests
{
    [Fact]
    public void ShouldChangeMaterial()
    {
        // Arrange
        var material = new Material("Carbon Steel");
        
        // Act
        material.Change("Stacked Leather");
        
        // Assert
        Assert.Equal(
            JsonConvert.SerializeObject(new Material("Stacked Leather")),
            JsonConvert.SerializeObject(material));
    }
}
