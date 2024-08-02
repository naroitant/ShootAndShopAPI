using ShootAndShopAPI.Domain.Common;
using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Person : BaseEntity
{
    protected Person() { }
    
    protected Person(
        string firstName, 
        string middleName,
        string lastName, 
        string phoneNumber, 
        Address address)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public string LastName { get; private set; }
    public string PhoneNumber { get; private set; }
    public Address Address { get; private set; }

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
