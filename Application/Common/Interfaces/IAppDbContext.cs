using Microsoft.EntityFrameworkCore;
using ShootAndShopAPI.Domain.Entities;

namespace Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<Ammo> Ammos { get; }
    DbSet<Axe> Axes { get; }
    DbSet<Color> Colors { get; }
    DbSet<Customer> Customers { get; }
    DbSet<Item> Items { get; }
    DbSet<Knife> Knives { get; }
    DbSet<LockType> LockTypes { get; }
    DbSet<Magazine> Magazines { get; }
    DbSet<Manufacturer> Manufacturers { get; }
    DbSet<Material> Materials { get; }
    DbSet<Order> Orders { get; }
    DbSet<Payment> Payments { get; }
    DbSet<ProductPrice> ProductPrices { get; }
    DbSet<RedDotSight> RedDotSights { get; }
    DbSet<Rifle> Rifles { get; }
    DbSet<RifleActionType> RifleActionTypes { get; }
    DbSet<SafetyType> SafetyTypes { get; }
    DbSet<Scope> Scopes { get; }
    DbSet<Seller> Sellers { get; }
    DbSet<ShoppingCart> ShoppingCarts { get; }
    DbSet<Shotgun> Shotguns { get; }
    DbSet<ShotgunActionType> ShotgunActionTypes { get; }
}
