using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class ActionType(string name) : BaseEntity
{
    public string Name { get; private set; } = name;

    public void Change(string name)
    {
        Name = name;
    }
}
