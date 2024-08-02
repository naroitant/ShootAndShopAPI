using ShootAndShopAPI.Domain.ValueObjects;

namespace ShootAndShopAPI.Domain.Entities;

public class Order : Set
{
    private Order() : base() { }
    
    public Order(ShoppingCart shoppingCart) : base(shoppingCart.Customer)
    {
        foreach (var item in shoppingCart.Items.Select(shoppingCartItem => 
            new Item(
                this, 
                shoppingCartItem.Product, 
                shoppingCartItem.Quantity)))
        {
            Items.Add(item);
        }

        CreatedAt = DateTimeOffset.Now;
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
