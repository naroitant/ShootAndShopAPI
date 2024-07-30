namespace ShootAndShopAPI.Domain.Entities;

public class Manufacturer(string name) : Quality(name)
{
    public List<Ammo> Ammos { get; private set; } = [];
    public List<Axe> Axes { get; private set; } = [];
    public List<Knife> Knives { get; private set; } = [];
    public List<Magazine> Magazines { get; private set; } = [];
    public List<RedDotSight> RedDotSights { get; private set; } = [];
    public List<Rifle> Rifles { get; private set; } = [];
    public List<Scope> Scopes { get; private set; } = [];
    public List<Shotgun> Shotguns { get; private set; } = [];
}
