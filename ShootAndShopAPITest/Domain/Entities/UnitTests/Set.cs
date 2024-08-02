using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class SetTests
{
    [Fact]
    public void ShouldGetTotalCost()
    {
        // Arrange
        var customer = new Customer(
            "Jake",
            "Travis",
            "Amundsen",
            "+18002002010",
            new Address(
                "123 Washington Street, apt 1",
                "New York",
                "New York",
                "United States",
                "10000"));
        var ammo = new Ammo(
            "757750308152",
            "DPX762X39123",
            "Cor Bon Hunter 7.62x39mm, 123 gr, Deep Penetrating, 20rd Box",
            new Manufacturer(name: "Con-Bon"),
            37.99m,
            25,
            124,
            1110);
        var rifle = new Rifle(
            "736676169344",
            "16934",
            "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
            new Manufacturer("Ruger"),
            799.00m,
            new Caliber(0.308, Units.Inches),
            new RifleActionType("Bolt"),
            22,
            4);
        var shoppingCart = new ShoppingCart(customer);
        shoppingCart.AddItem(ammo);
        shoppingCart.AddItem(rifle);
        
        // Act
        var totalCostInUsd = shoppingCart.GetTotalCostInUsd();

        // Assert
        Assert.Equal(836.99m, totalCostInUsd);
    }
}
