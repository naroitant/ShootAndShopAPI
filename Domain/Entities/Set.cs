using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Set : BaseEntity
{
    protected Set() : base() { }
    
    protected Set(
        Customer customer, 
        List<Item> items)
    {
        Customer = customer;
    }

    public Customer Customer { get; protected init; }
    public Guid CustomerId { get; protected set; }
    public List<Item> Items { get; protected set; } = [];
}
