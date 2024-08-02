using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Customer : Person
{
    private Customer() : base() { }
    
    public Customer(
        string firstName,
        string middleName,
        string lastName,
        string phoneNumber,
        Address address)
        : base(firstName, middleName, lastName, phoneNumber, address) { }

    public List<Order> Orders { get; private set; } = [];
    public ShoppingCart ShoppingCart { get; private set; }
}
