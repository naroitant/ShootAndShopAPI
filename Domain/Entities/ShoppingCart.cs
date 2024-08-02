namespace ShootAndShopAPI.Domain.Entities;

public class ShoppingCart : Set
{
    private ShoppingCart() : base() { }
    
    public ShoppingCart(Customer customer) : base(customer)
    {
        Customer = customer;
    }
    
    public void AddItem(Product product)
    {
        var item = new Item(this, product, 1);
        Items.Add(item);
    }
    
    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }
    
    public void Clear()
    {
        Items.Clear();
    }
    
    public Order Checkout()
    {
        if (Items.Count == 0)
        {
            throw new Exception();
        }
        
        var order = new Order(this);
        Items.Clear();
        return order;
    }
}
