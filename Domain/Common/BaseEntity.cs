﻿namespace ShootAndShopAPI.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; private set; } = new Guid();
}
