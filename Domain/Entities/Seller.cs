using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Seller : Person
{
    private Seller() : base() { }
    
    public Seller(
        string firstName,
        string middleName,
        string lastName,
        string phoneNumber,
        Address address)
        : base(firstName, middleName, lastName, phoneNumber, address) { }

    public List<Payment> Payments { get; private set; } = [];
}
