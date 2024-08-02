using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class ProductPrice : BaseEntity
{
    private ProductPrice() { }
    
    public ProductPrice(
        DateTimeOffset validSince,
        decimal priceInUsd,
        Product product)
    {
        ValidSince = validSince;
        PriceInUsd = priceInUsd;
        Product = product;
    }

    public DateTimeOffset ValidSince { get; private set; }
    public decimal PriceInUsd { get; private set; }
    public Product Product { get; private set; }
    public Guid ProductId { get; private set; }
}
