namespace ShootAndShopAPI.Domain.Entities;

public class LockType : Quality
{
    private LockType() : base() { }
    
    public LockType(string name) : base(name) { }
}
