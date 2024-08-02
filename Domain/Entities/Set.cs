using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public abstract class Set : BaseEntity
{
    protected Set() : base() { }
    
    protected Set(Customer customer) : base()
    {
        Customer = customer;
    }

    public Customer Customer { get; protected init; }
    public Guid CustomerId { get; protected init; }
    public List<Item> Items { get; protected set; } = [];

    public decimal GetTotalCostInUsd()
    {
        return Items.Sum(item => item.Product.PriceInUsd * item.Quantity);
    }
}
