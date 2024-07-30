using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class QualityTests
{
    private class QualityTest(string name) : Quality(name) { }
    
    [Fact]
    public void ShouldChangeName()
    {
        // Arrange
        var qualityTest = new QualityTest("Lever");
        
        // Act
        qualityTest.ChangeName("Bolt");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new QualityTest("Bolt")),
            JsonConvert.SerializeObject(qualityTest));
    }
}
