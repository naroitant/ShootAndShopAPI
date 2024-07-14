using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class LockTypeTests
{
    [Fact]
    public void ShouldChangeLockType()
    {
        // Arrange
        var lockType = new LockType("Cable");
        
        // Act
        lockType.Change("Trigger");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new LockType("Trigger")),
            JsonConvert.SerializeObject(lockType));
    }
}
