namespace Domain.Entities;

public class Item(Product product, int quality) : Product(product.Sku,
    product.ManufacturerNumber, product.Name, product.Manufacturer)
{
    public int Quantity { get; private set; } = quality;
    public Product Product { get; private set; } = product;

    public void Update(Product product, int quality)
    {
        Product = product;
        Quantity = quality;
    }
}
