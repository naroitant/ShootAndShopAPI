namespace ShootAndShopAPI.Domain.Entities;

public class RifleActionType : ActionType
{
    private RifleActionType() : base() { }
    
    public RifleActionType(string name) : base(name) { }
    
    public List<Rifle> Rifles { get; private set; } = [];
}
