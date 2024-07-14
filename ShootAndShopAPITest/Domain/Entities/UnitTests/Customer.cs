using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class CustomerTests
{
    [Fact]
    public void ShouldChangeCustomerAddress()
    {
        // Arrange
        var customer = new Customer(
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
                "10000"));
        
        // Act
        var address = new Address(
            "20 Carla Marxa Street, apt 1",
            "Moscow",
            "Moscow",
            "Russia",
            "100000");
        customer.ChangeAddress(address);
        
        // Assert
        Assert.Equal(address, customer.Address);
    }
    
    [Fact]
    public void ShouldChangeCustomerPhoneNumber()
    {
        // Arrange
        var customer = new Customer(
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
                "10000"));
        
        // Act
        customer.ChangePhoneNumber(
            "+19004505080");
        
        // Assert
        Assert.Equal("+19004505080", customer.PhoneNumber);
    }
    
    [Fact]
    public void ShouldChangeCustomerName()
    {
        // Arrange
        var customer = new Customer(
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
                "10000"));
        
        // Act
        customer.ChangeName("Alfred", "Gregory", "Thomson");
        
        // Assert
        Assert.Equal("Alfred Gregory Thomson",
            $"{customer.FirstName} {customer.MiddleName} {customer.LastName}");
    }
}
