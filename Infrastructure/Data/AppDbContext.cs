using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using ShootAndShopAPI.Domain.Common;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;
using System.Reflection;

namespace Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options), IAppDbContext
{
    public DbSet<Ammo> Ammos => Set<Ammo>();
    public DbSet<Axe> Axes => Set<Axe>();
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<Knife> Knives => Set<Knife>();
    public DbSet<LockType> LockTypes => Set<LockType>();
    public DbSet<Magazine> Magazines => Set<Magazine>();
    public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
    public DbSet<Material> Materials => Set<Material>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<ProductPrice> ProductPrices => Set<ProductPrice>();
    public DbSet<RedDotSight> RedDotSights => Set<RedDotSight>();
    public DbSet<Rifle> Rifles => Set<Rifle>();
    public DbSet<RifleActionType> RifleActionTypes => Set<RifleActionType>();
    public DbSet<SafetyType> SafetyTypes => Set<SafetyType>();
    public DbSet<Scope> Scopes => Set<Scope>();
    public DbSet<Seller> Sellers => Set<Seller>();
    public DbSet<ShoppingCart> ShoppingCarts => Set<ShoppingCart>();
    public DbSet<Shotgun> Shotguns => Set<Shotgun>();
    public DbSet<ShotgunActionType> ShotgunActionTypes => Set<ShotgunActionType>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());

        // builder
        //     .Entity<Ammo>()
        //     .HasKey(a => a.Id);
        builder
            .Entity<Ammo>()
            .HasOne(a => a.Manufacturer)
            .WithMany(m => m.Ammos)
            .HasForeignKey(a => a.ManufacturerId);

        // builder
        //     .Entity<Axe>()
        //     .HasKey(a => a.Id);
        builder
            .Entity<Axe>()
            .HasOne(a => a.Manufacturer)
            .WithMany(m => m.Axes)
            .HasForeignKey(a => a.ManufacturerId);
        
        // builder
        //     .Entity<Color>()
        //     .HasKey(c => c.Id);
        
        // builder
        //     .Entity<Customer>()
        //     .HasKey(c => c.Id);
        builder
            .Entity<Customer>()
            .OwnsOne(c => c.Address, a =>
            {
                a.Property(p => p.AddressLine);
                a.Property(p => p.City);
                a.Property(p => p.State);
                a.Property(p => p.Country);
                a.Property(p => p.PostalCode);
            });
        
        builder
            .Entity<FireArm>()
            .OwnsOne(f => f.Caliber, c =>
            {
                c.Property(p => p.Amount);
                c.Property(p => p.Unit);
            });

        // builder
        //     .Entity<Item>()
        //     .HasKey(i => i.Id);
        builder
            .Entity<Item>()
            .HasOne(i => i.Product)
            .WithMany(p => p.Items)
            .HasForeignKey(i => i.ProductId);

        // builder
        //     .Entity<Knife>()
        //     .HasKey(k => k.Id);
        builder
            .Entity<Knife>()
            .HasOne(k => k.Manufacturer)
            .WithMany(m => m.Knives)
            .HasForeignKey(k => k.ManufacturerId);
        
        // builder
        //     .Entity<LockType>()
        //     .HasKey(l => l.Id);

        // builder
        //     .Entity<Magazine>()
        //     .HasKey(m => m.Id);
        builder
            .Entity<Magazine>()
            .HasOne(m => m.Manufacturer)
            .WithMany(m => m.Magazines)
            .HasForeignKey(m => m.ManufacturerId);
        
        // builder
        //     .Entity<Manufacturer>()
        //     .HasKey(m => m.Id);

        builder
            .Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);
        builder
            .Entity<Order>()
            .Property(o => o.Status)
            .HasConversion(
                o => o.ToString(),
                o => (OrderStatuses)Enum.Parse(typeof(OrderStatuses), o));

        // builder
        //     .Entity<Payment>()
        //     .HasKey(p => p.Id);
        builder
            .Entity<Payment>()
            .HasOne(p => p.Seller)
            .WithMany(s => s.Payments)
            .HasForeignKey(p => p.SellerId);

        // builder
        //     .Entity<ProductPrice>()
        //     .HasKey(p => p.Id);
        builder
            .Entity<ProductPrice>()
            .HasOne(p => p.Product)
            .WithMany(p => p.PriceHistory)
            .HasForeignKey(p => p.ProductId);
        
        // builder
        //     .Entity<RedDotSight>()
        //     .HasKey(r => r.Id);
        
        // builder
        //     .Entity<Rifle>()
        //     .HasKey(r => r.Id);
        
        // builder
        //     .Entity<RifleActionType>()
        //     .HasKey(r => r.Id);
        
        // builder
        //     .Entity<SafetyType>()
        //     .HasKey(s => s.Id);
        
        // builder
        //     .Entity<Scope>()
        //     .HasKey(s => s.Id);
        
        builder
            .Entity<Seller>()
            .OwnsOne(s => s.Address, a =>
            {
                a.Property(p => p.AddressLine);
                a.Property(p => p.City);
                a.Property(p => p.State);
                a.Property(p => p.Country);
                a.Property(p => p.PostalCode);
            });
        
        builder
            .Entity<ShoppingCart>()
            .HasOne(s => s.Customer)
            .WithOne(c => c.ShoppingCart)
            .HasForeignKey<ShoppingCart>(s => s.CustomerId);
        
        // builder
        //     .Entity<Shotgun>()
        //     .HasKey(s => s.Id);
        
        // builder
        //     .Entity<ShotgunActionType>()
        //     .HasKey(s => s.Id);
    }
}
