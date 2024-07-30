using ShootAndShopAPI.Domain.Common;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Person(
    string firstName, 
    string middleName,
    string lastName, 
    string phoneNumber, 
    Address address)
    : BaseEntity
{
    public string FirstName { get; private set; } = firstName;
    public string MiddleName { get; private set; } = middleName;
    public string LastName { get; private set; } = lastName;
    public string PhoneNumber { get; private set; } = phoneNumber;
    public Address Address { get; private set; } = address;

    public void ChangeAddress(Address newAddress)
    {
        Address = newAddress;
    }
    
    public void ChangeName(
        string newFirstName,
        string newMiddleName,
        string newLastName)
    {
        FirstName = newFirstName;
        MiddleName = newMiddleName;
        LastName = newLastName;
    }
    
    public void ChangePhoneNumber(string newPhoneNumber)
    {
        PhoneNumber = newPhoneNumber;
    }
}
