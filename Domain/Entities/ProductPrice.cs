using Domain.Common;

namespace Domain.Entities;

public class ProductPrice(DateTimeOffset validSince, decimal priceInUsd)
    : BaseEntity
{
    public DateTimeOffset ValidSince { get; private set; } = validSince;
    public decimal PriceInUsd { get; private set; } = priceInUsd;

    public void Update(DateTimeOffset validSince, decimal priceInUsd)
    {
        ValidSince = validSince;
        PriceInUsd = priceInUsd;
    }
}
