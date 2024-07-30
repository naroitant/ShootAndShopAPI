using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class ItemTests
{
    [Fact]
    public void ShouldAddOneToItemQuantity()
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
        
        // Act
        item.AddOne();
        
        // Assert
        Assert.Equal(16, item.Quantity);
    }

    [Fact]
    public void ShouldReduceItemQuantityByOne()
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
        
        // Act
        item.ReduceByOne();
        
        // Assert
        Assert.Equal(14, item.Quantity);
    }

    [Fact]
    public void ShouldAddNumberToItemQuantity()
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
        
        // Act
        item.Add(10);
        
        // Assert
        Assert.Equal(25, item.Quantity);
    }
    
    [Fact]
    public void ShouldReduceItemQuantityByNumber()
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
        
        // Act
        item.Reduce(10);
        
        // Assert
        Assert.Equal(5, item.Quantity);
    }
}
