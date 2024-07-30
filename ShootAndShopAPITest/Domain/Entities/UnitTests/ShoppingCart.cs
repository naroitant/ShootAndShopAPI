using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ShoppingCartTests
{
    [Fact]
    public void ShouldAddProduct()
    {
        // Arrange
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                new Address(
                    "123 Washington Street, apt 1",
                    "New York",
                    "New York",
                    "United States",
                    "10000")),
            []);
        
        // Act
        var product = new Rifle(
            "736676169344",
            "16934",
            "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
            new Manufacturer("Ruger"),
            799.00m,
            new Caliber(0.308, Units.Inches),
            new RifleActionType("Bolt"),
            22,
            4);
        shoppingCart.AddItem(product);
        
        // Assert
        Assert.Equal([new Item(product, 1)],
            shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldRemoveItem()
    {
        // Arrange
        var item = new Item(
            new Rifle(
                "736676169344",
                "16934",
                "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
                new Manufacturer("Ruger"),
                799.00m,
                new Caliber(0.308, Units.Inches),
                new RifleActionType("Bolt"),
                22,
                4),
            15);
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                new Address(
                    "123 Washington Street, apt 1",
                    "New York",
                    "New York",
                    "United States",
                    "10000")),
            [item]);
        
        // Act
        shoppingCart.RemoveItem(item);
        
        // Assert
        Assert.Equal([], shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldClear()
    {
        // Arrange
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                new Address(
                    "123 Washington Street, apt 1",
                    "New York",
                    "New York",
                    "United States",
                    "10000")),
            []);
        
        // Act
        shoppingCart.Clear();
        
        // Assert
        Assert.Equal([], shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldPreventCheckoutIfShoppingCartIsEmpty()
    {
        // Arrange
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                new Address(
                    "123 Washington Street, apt 1",
                    "New York",
                    "New York",
                    "United States",
                    "10000")),
            []);
        
        // Act
        var exception = Record.Exception(() => shoppingCart.Checkout()); 
        
        // Assert
        Assert.IsType<Exception>(exception);
    }
}
