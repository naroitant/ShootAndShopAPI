namespace ShootAndShopAPI.Domain.Entities;

public class Item(Product product, int quantity) : Product(
    product.Sku, product.ManufacturerNumber, product.Name,
    product.Manufacturer, product.Category)
{
    public int Quantity { get; private set; } = quantity;
    public Product Product { get; private set; } = product;
    
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj))
        {
            return false;
        } else if (ReferenceEquals(this, obj))
        {
            return true;
        } else if (obj.GetType() != this.GetType())
        {
            return false;
        }

        Item other = (Item) obj;

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
