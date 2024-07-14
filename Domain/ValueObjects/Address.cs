namespace ShootAndShopAPI.Domain.ValueObjects;

public class Address(string addressLine, string city, string state,
    string country, string postalCode)
{
    public string AddressLine { get; private set; } = addressLine;
    public string City { get; private set; } = city;
    public string State { get; private set; } = state;
    public string Country { get; private set; } = country;
    public string PostalCode { get; private set; } = postalCode;
}
