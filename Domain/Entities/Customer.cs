using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Customer(
    string firstName,
    string middleName,
    string lastName,
    string phoneNumber,
    Address address)
    : Person(firstName, middleName, lastName, phoneNumber, address)
{
    public List<Order> Orders { get; private set; } = [];
    public ShoppingCart? ShoppingCart { get; private set; }
}
