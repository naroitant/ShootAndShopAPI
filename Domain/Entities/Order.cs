using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Order(
    ShoppingCart shoppingCart,
    DateTimeOffset createdAt)
    : Set(shoppingCart.Customer, shoppingCart.Items)
{
    public DateTimeOffset CreatedAt { get; private set; } = createdAt;
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
