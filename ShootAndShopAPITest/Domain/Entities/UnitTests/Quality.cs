using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class QualityTests
{
    private class QualityTest(string name) : Quality(name) { }
    
    [Fact]
    public void ShouldChangeActionType()
    {
        // Arrange
        var qualityTest = new QualityTest("Lever");
        
        // Act
        qualityTest.Change("Bolt");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new QualityTest("Bolt")),
            JsonConvert.SerializeObject(qualityTest));
    }
}
