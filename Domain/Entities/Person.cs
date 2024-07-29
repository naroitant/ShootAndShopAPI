using ShootAndShopAPI.Domain.Common;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Person(string firstName, string middleName,
    string lastName, string phoneNumber, Address address)
    : BaseEntity
{
    public string FirstName { get; private set; } = firstName;
    public string MiddleName { get; private set; } = middleName;
    public string LastName { get; private set; } = lastName;
    public string PhoneNumber { get; private set; } = phoneNumber;
    public Address Address { get; private set; } = address;

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
