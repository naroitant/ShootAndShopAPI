using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class OrderTests
{
    [Fact]
    public void ShouldCancel()
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
        Assert.Equal(OrderStatuses.Cancelled, order.Status);
    }
    
    [Fact]
    public void ShouldPay()
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
        Assert.Equal(OrderStatuses.Paid, order.Status);
    }
}
