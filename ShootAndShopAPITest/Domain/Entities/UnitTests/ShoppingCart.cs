using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ShoppingCartTests
{
    [Fact]
    public void ShouldAddProduct()
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
        var shoppingCart = new ShoppingCart(customer);
        
        // Act
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
        shoppingCart.AddItem(rifle);
        
        // Assert
        Assert.Equal([new Item(shoppingCart, rifle, 1)], shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldRemoveItem()
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
        var shoppingCart = new ShoppingCart(customer);
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
        var item = new Item(shoppingCart, rifle, 15);
        
        // Act
        shoppingCart.RemoveItem(item);
        
        // Assert
        Assert.Equal([], shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldClear()
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
        var shoppingCart = new ShoppingCart(customer);
        
        // Act
        shoppingCart.Clear();
        
        // Assert
        Assert.Equal([], shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldPreventCheckoutIfShoppingCartIsEmpty()
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
        var shoppingCart = new ShoppingCart(customer);
        
        // Act
        var exception = Record.Exception(() => shoppingCart.Checkout()); 
        
        // Assert
        Assert.IsType<Exception>(exception);
    }
}
