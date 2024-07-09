using Domain.Common;

namespace Domain.Entities;

public abstract class Set(List<Product> products) : BaseEntity
{
    public List<Product> Products { get; protected set; } = [];

    protected void AddProduct(Product product)
    {
        products.Add(product);
    }
    
    protected void Clear()
    {
        products.Clear();
    }
}
