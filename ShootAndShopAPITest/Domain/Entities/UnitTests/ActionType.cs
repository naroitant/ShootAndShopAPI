using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ActionTypeTests
{
    [Fact]
    public void ShouldChangeActionType()
    {
        // Arrange
        var actionType = new ActionType("Lever");
        
        // Act
        actionType.Change("Bolt");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new ActionType("Bolt")),
            JsonConvert.SerializeObject(actionType));
    }
}
