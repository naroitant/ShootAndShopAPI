namespace ShootAndShopAPI.Domain.Entities;

public class ShotgunActionType : ActionType
{
    private ShotgunActionType() : base() { }
    
    public ShotgunActionType(string name) : base(name) { }

    public List<Shotgun> Shotguns { get; private set; } = [];
}
