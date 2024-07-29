using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Seller(string firstName, string middleName,
    string lastName, string phoneNumber, Address address)
    : Person(firstName, middleName, lastName, phoneNumber, address) { }
