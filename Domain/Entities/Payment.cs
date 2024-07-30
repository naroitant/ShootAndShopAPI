using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class Payment(
    DateTimeOffset paidAt, 
    Seller seller)
    : BaseEntity
{
    public DateTimeOffset PaidAt { get; private set; } = paidAt;
    public Seller Seller { get; private set; } = seller;
    public int SellerId { get; private set; }
}
