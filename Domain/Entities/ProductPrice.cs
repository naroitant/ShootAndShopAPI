using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class ProductPrice(DateTimeOffset validSince, decimal priceInUsd)
    : BaseEntity
{
    public DateTimeOffset ValidSince { get; private set; } = validSince;
    public decimal PriceInUsd { get; private set; } = priceInUsd;
}
