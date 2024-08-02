using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class Item : BaseEntity
{
    private Item() : base() { }
    
    public Item(
        Set set,
        Product product, 
        int quantity)
    {
        Set = set;
        Product = product;
        Quantity = quantity;
    }

    public Set Set { get; private set; }
    public Product Product { get; private set; }
    public Guid ProductId { get; private set; }
    public int Quantity { get; private set; }
    
    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        }
        
        if (ReferenceEquals(this, obj))
        {
            return true;
        }
        
        if (obj.GetType() != this.GetType())
        {
            return false;
        }

        var other = (Item) obj;

        return Quantity.Equals(other.Quantity) &&
               Product.Equals(other.Product);
    }

    public override int GetHashCode()
    {
        return new {Quantity, Product}.GetHashCode();
    }

    public void Add(int addedQuantity)
    {
        Quantity += addedQuantity;
    }
    
    public void AddOne()
    {
        Quantity += 1;
    }
    
    public void Reduce(int reducedQuantity)
    {
        Quantity -= reducedQuantity;
    }
    
    public void ReduceByOne()
    {
        Quantity -= 1;
    }
}
