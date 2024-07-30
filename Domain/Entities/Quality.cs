using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Quality(string name) : BaseEntity
{
    public string Name { get; private set; } = name;

    public void ChangeName(string newName)
    {
        Name = newName;
    }
}
