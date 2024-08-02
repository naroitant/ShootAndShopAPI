namespace ShootAndShopAPI.Domain.Entities;

public class ShoppingCart : Set
{
    private ShoppingCart() : base() { }
    
    public ShoppingCart(
        Customer customer,
        List<Item> items) : base(customer, [])
    {
        Customer = customer;
    }
    
    public void AddItem(Product product)
    {
        var item = new Item(product, 1);
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
    
    public void Checkout()
    {
        if (Items.Count != 0)
        {
            var order = new Order(this, DateTimeOffset.Now);
        }
        else
        {
            throw new Exception();
        }
    }
}
