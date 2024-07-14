using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ColorTests
{
    [Fact]
    public void ShouldChangeColor()
    {
        // Arrange
        var color = new Color("Black");
        
        // Act
        color.Change("Green");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new Color("Green")),
            JsonConvert.SerializeObject(color));
    }
}
