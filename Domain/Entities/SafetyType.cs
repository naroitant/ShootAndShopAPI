using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class SafetyType(string name) : BaseEntity
{
    public string Name { get; private set; } = name;

    public void Change(string name)
    {
        Name = name;
    }
}
