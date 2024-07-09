using Domain.ValueObjects;

namespace Domain.Entities;

public class Customer(string firstName, string middleName,
    string lastName, string phoneNumber, string emailAddress, Address address)
    : Person(firstName, middleName, lastName, phoneNumber, emailAddress,
        address) { }
