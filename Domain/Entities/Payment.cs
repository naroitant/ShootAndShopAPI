using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class Payment : BaseEntity
{
    private Payment() { }
    
    public Payment(
        DateTimeOffset paidAt, 
        Seller seller)
    {
        PaidAt = paidAt;
        Seller = seller;
    }

    public DateTimeOffset PaidAt { get; private set; }
    public Seller Seller { get; private set; }
    public Guid SellerId { get; private set; }
}
