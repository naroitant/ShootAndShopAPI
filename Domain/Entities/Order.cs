using Domain.ValueObjects;

namespace Domain.Entities;

public class Order(List<Product> products, DateTimeOffset createdAt)
    : Set(products)
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
