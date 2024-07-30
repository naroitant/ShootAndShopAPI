using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPITest.Domain.Entities.UnitTests;

public class PersonTests
{
    private class PersonTest(
        string firstName,
        string middleName,
        string lastName,
        string phoneNumber,
        Address address)
        : Person(firstName, middleName, lastName, phoneNumber, address) { }
    
    [Fact]
    public void ShouldChangeAddress()
    {
        // Arrange
        var personTest = new PersonTest(
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
        
        // Act
        var address = new Address(
            "20 Carla Marxa Street, apt 1",
            "Moscow",
            "Moscow",
            "Russia",
            "100000");
        personTest.ChangeAddress(address);
        
        // Assert
        Assert.Equal(address, personTest.Address);
    }
    
    [Fact]
    public void ShouldChangePhoneNumber()
    {
        // Arrange
        var personTest = new PersonTest(
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
        
        // Act
        personTest.ChangePhoneNumber(
            "+19004505080");
        
        // Assert
        Assert.Equal("+19004505080", personTest.PhoneNumber);
    }
    
    [Fact]
    public void ShouldChangeName()
    {
        // Arrange
        var personTest = new PersonTest(
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
        
        // Act
        personTest.ChangeName("Alfred", "Gregory", "Thomson");
        
        // Assert
        Assert.Equal("Alfred Gregory Thomson",
            $"{personTest.FirstName} {personTest.MiddleName} {personTest.LastName}");
    }
}
