using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ShoppingCartTests
{
    [Fact]
    public void ShouldAddProductToShoppingCart()
    {
        // Arrange
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                "j.amundsen@gmail.com",
                new Address(
                    "123 Washington Street, apt 1",
                    "New York",
                    "New York",
                    "United States",
                    "10000")),
            []);
        
        // Act
        var product = new FireArm(
            "736676169344",
            "16934",
            "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
            new Manufacturer("Ruger"),
            new Category("Rifles"),
            new Caliber(0.308, Unit.Inches),
            new ActionType("Bolt"),
            22,
            4);
        shoppingCart.AddItem(product);
        
        // Assert
        Assert.Equal([new Item(product, 1)],
            shoppingCart.Items);
    }
    
    [Fact]
    public void ShouldRemoveItemFromShoppingCart()
    {
        // Arrange
        var item = new Item(
            new FireArm(
                "736676169344",
                "16934",
                "Ruger American Rifle, .308 Win, 22\" Barrel, Vortex Crossfire II Scope, Mounted",
                new Manufacturer("Ruger"),
                new Category("Rifles"),
                new Caliber(0.308, Unit.Inches),
                new ActionType("Bolt"),
                22,
                4),
            15);
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                "j.amundsen@gmail.com",
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
    public void ShouldClearShoppingCart()
    {
        // Arrange
        var shoppingCart = new ShoppingCart(
            new Customer(
                "Jake",
                "Travis",
                "Amundsen",
                "+18002002010",
                "j.amundsen@gmail.com",
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
                "j.amundsen@gmail.com",
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
