using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Order : Set
{
    private Order() : base() { }
    
    public Order(
        ShoppingCart shoppingCart,
        DateTimeOffset createdAt)
        : base(shoppingCart.Customer, shoppingCart.Items)
    {
        CreatedAt = createdAt;
    }

    public DateTimeOffset CreatedAt { get; private set; }
    public OrderStatuses Status { get; private set; } = OrderStatuses.Active;

    public void Cancel()
    {
        Status = OrderStatuses.Cancelled;
    }

    public void Pay()
    {
        Status = OrderStatuses.Paid;
    }
}
