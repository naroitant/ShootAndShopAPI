using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Set(Customer customer, List<Item> items) : BaseEntity
{
    public Customer Customer { get; protected init; } = customer;
    public List<Item> Items { get; protected set; } = [];
}
