using ShootAndShopAPI.Domain.Common;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Person(string firstName, string middleName,
    string lastName, string phoneNumber, string emailAddress, Address address)
    : BaseEntity
{
    public string FirstName { get; protected set; } = firstName;
    public string MiddleName { get; protected set; } = middleName;
    public string LastName { get; protected set; } = lastName;
    public string PhoneNumber { get; protected set; } = phoneNumber;
    public Address Address { get; protected set; } = address;

    public void ChangeAddress(Address address)
    {
        Address = address;
    }
    
    public void ChangeName(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
    
    public void ChangePhoneNumber(string phoneNumber)
    {
        PhoneNumber = phoneNumber;
    }
}
