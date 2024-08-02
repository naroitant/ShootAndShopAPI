using Microsoft.EntityFrameworkCore;
using ShootAndShopAPI.Domain.Entities;

namespace Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<Color> Colors { get; }
    DbSet<Customer> Customers { get; }
    DbSet<Item> Items { get; }
    DbSet<LockType> LockTypes { get; }
    DbSet<Manufacturer> Manufacturers { get; }
    DbSet<Material> Materials { get; }
    DbSet<Payment> Payments { get; }
    DbSet<Product> Products { get; }
    DbSet<ProductPrice> ProductPrices { get; }
    DbSet<RifleActionType> RifleActionTypes { get; }
    DbSet<SafetyType> SafetyTypes { get; }
    DbSet<Seller> Sellers { get; }
    DbSet<Set> Sets { get; }
    DbSet<ShotgunActionType> ShotgunActionTypes { get; }
}
