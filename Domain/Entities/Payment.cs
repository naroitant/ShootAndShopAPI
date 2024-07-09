using Domain.Common;

namespace Domain.Entities;

public class Payment(DateTimeOffset paidAt) : BaseEntity
{
    public DateTimeOffset PaidAt { get; private set; } = paidAt;
}
