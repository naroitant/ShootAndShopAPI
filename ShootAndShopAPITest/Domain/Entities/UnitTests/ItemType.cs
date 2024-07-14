using Newtonsoft.Json;
using ShootAndShopAPI.Domain.Entities;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class CategoryTests
{
    [Fact]
    public void ShouldChangeItemType()
    {
        // Arrange
        var itemType = new Category("Pistol");
        
        // Act
        itemType.Change("Rifle");
        
        // Assert
        Assert.Equal(JsonConvert.SerializeObject(new Category("Rifle")),
            JsonConvert.SerializeObject(itemType));
    }
}
