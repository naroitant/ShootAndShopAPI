using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Quality : BaseEntity
{
    protected Quality() { }
    
    protected Quality(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public void ChangeName(string newName)
    {
        Name = newName;
    }
}
