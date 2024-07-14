using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class SafetyTypeTests
{
    [Fact]
    public void ShouldChangeSafetyType()
    {
        // Arrange
        var safetyType = new SafetyType("Pivot");
        
        // Act
        safetyType.Change("Thumb");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new SafetyType("Thumb")),
            JsonConvert.SerializeObject(safetyType));
    }
}
