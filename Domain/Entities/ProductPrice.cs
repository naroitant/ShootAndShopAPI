using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class ProductPrice(
    DateTimeOffset validSince,
    decimal priceInUsd,
    Product product)
    : BaseEntity
{
    public DateTimeOffset ValidSince { get; private set; } = validSince;
    public decimal PriceInUsd { get; private set; } = priceInUsd;
    public Product Product { get; private set; } = product;
    public int ProductId { get; private set; }
}
