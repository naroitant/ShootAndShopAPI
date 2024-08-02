namespace ShootAndShopAPI.Domain.Entities;

public class SafetyType : Quality
{
    private SafetyType() { }
    
    public SafetyType(string name) : base(name) { }
}
