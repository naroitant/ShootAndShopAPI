using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Seller(string firstName, string middleName,
    string lastName, string phoneNumber, string emailAddress, Address address)
    : Person(firstName, middleName, lastName, phoneNumber, emailAddress,
        address) { }
