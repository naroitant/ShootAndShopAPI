using Domain.Common;

namespace Domain.Entities;

public class Material(string name) : BaseEntity
{
    public string Name { get; private set; } = name;

    public void Update(string name)
    {
        Name = name;
    }
}
