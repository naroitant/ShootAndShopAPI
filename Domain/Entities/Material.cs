namespace ShootAndShopAPI.Domain.Entities;

public class Material : Quality
{
    private Material() : base() { }
    
    public Material(string name) : base(name) { }
}
