using ShootAndShopAPI.Domain.Common;

namespace ShootAndShopAPI.Domain.Entities;

public class Payment(DateTimeOffset paidAt) : BaseEntity
{
    public DateTimeOffset PaidAt { get; private set; } = paidAt;
}
