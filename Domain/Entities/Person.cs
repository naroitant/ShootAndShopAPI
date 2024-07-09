using Domain.Common;
using Domain.ValueObjects;

namespace Domain.Entities;

public abstract class Person(string firstName, string middleName,
    string lastName, string phoneNumber, string emailAddress, Address address)
    : BaseEntity
{
    public string FirstName { get; protected set; } = firstName;
    public string MiddleName { get; protected set; } = middleName;
    public string LastName { get; protected set; } = lastName;
    public string PhoneNumber { get; protected set; } = phoneNumber;
    public string EmailAddress { get; protected set; } = emailAddress;

    public Address Address { get; protected set; } = address;
    
    public void Update(string firstName, string middleName, string lastName,
        string phoneNumber, string emailAddress, Address address)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        EmailAddress = emailAddress;
        Address = address;
    }
}
