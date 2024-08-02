namespace ShootAndShopAPI.Domain.Entities;

public abstract class ActionType : Quality
{
    protected ActionType() : base() { }
    
    protected ActionType(string name) : base(name) { }
}
