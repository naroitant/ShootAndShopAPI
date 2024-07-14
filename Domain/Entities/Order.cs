using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Order(ShoppingCart shoppingCart, DateTimeOffset createdAt)
    : Set(shoppingCart.Customer, shoppingCart.Items)
{
    public DateTimeOffset CreatedAt { get; private set; } = createdAt;
    public OrderStatus Status { get; private set; } = OrderStatus.Active;

    public void Cancel()
    {
        Status = OrderStatus.Cancelled;
    }

    public void Pay()
    {
        Status = OrderStatus.Paid;
    }
}
