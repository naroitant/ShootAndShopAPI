using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class OrderTests
{
    [Fact]
    public void ShouldCancelOrder()
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
        var order = new Order(shoppingCart, DateTimeOffset.Now);
        
        // Act
        order.Cancel();
        
        // Assert
        Assert.Equal(OrderStatus.Cancelled, order.Status);
    }
    
    [Fact]
    public void ShouldPayOrder()
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
        var order = new Order(shoppingCart, DateTimeOffset.Now);
        
        // Act
        order.Pay();
        
        // Assert
        Assert.Equal(OrderStatus.Paid, order.Status);
    }
}
