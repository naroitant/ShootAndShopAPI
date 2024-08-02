using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using ShootAndShopAPI.Domain.Entities;
using ShootAndShopAPI.Domain.ValueObjects;
using System.Reflection;

namespace Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options), IAppDbContext
{
    public DbSet<Color> Colors => Set<Color>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Item> Items => Set<Item>();
    public DbSet<LockType> LockTypes => Set<LockType>();
    public DbSet<Manufacturer> Manufacturers => Set<Manufacturer>();
    public DbSet<Material> Materials => Set<Material>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Product> Products => Set<Product>();
    public DbSet<ProductPrice> ProductPrices => Set<ProductPrice>();
    public DbSet<RifleActionType> RifleActionTypes => Set<RifleActionType>();
    public DbSet<SafetyType> SafetyTypes => Set<SafetyType>();
    public DbSet<Seller> Sellers => Set<Seller>();
    public DbSet<Set> Sets => Set<Set>();
    public DbSet<ShotgunActionType> ShotgunActionTypes =>
        Set<ShotgunActionType>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(
            Assembly.GetExecutingAssembly());

        builder
            .Entity<Ammo>()
            .HasOne(a => a.Manufacturer)
            .WithMany(m => m.Ammos)
            .HasForeignKey(a => a.ManufacturerId);

        builder
            .Entity<Axe>()
            .HasOne(a => a.Manufacturer)
            .WithMany(m => m.Axes)
            .HasForeignKey(a => a.ManufacturerId);

        builder
            .Entity<Customer>()
            .ToTable("customer")
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

        builder
            .Entity<Item>()
            .ToTable("item")
            .HasOne(i => i.Product)
            .WithMany(p => p.Items)
            .HasForeignKey(i => i.ProductId);

        builder
            .Entity<Knife>()
            .HasOne(k => k.Manufacturer)
            .WithMany(m => m.Knives)
            .HasForeignKey(k => k.ManufacturerId);
        builder
            .Entity<Knife>()
            .Property(k => k.BladeStyle)
            .HasConversion(
                b => b.ToString(),
                b => (BladeStyles)Enum.Parse(typeof(BladeStyles), b));
        builder
            .Entity<Knife>()
            .Property(k => k.KnifeStyle)
            .HasConversion(
                k => k.ToString(),
                k => (KnifeStyles)Enum.Parse(typeof(KnifeStyles), k));

        builder
            .Entity<LockType>()
            .ToTable("lock_type");
        
        builder
            .Entity<Magazine>()
            .HasOne(m => m.Manufacturer)
            .WithMany(m => m.Magazines)
            .HasForeignKey(m => m.ManufacturerId);
        
        builder
            .Entity<Manufacturer>()
            .ToTable("manufacturer");
        
        builder
            .Entity<Material>()
            .ToTable("material");

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

        builder
            .Entity<Payment>()
            .ToTable("payment")
            .HasOne(p => p.Seller)
            .WithMany(s => s.Payments)
            .HasForeignKey(p => p.SellerId);
        
        builder
            .Entity<Product>()
            .ToTable("product");
        
        builder
            .Entity<ProductPrice>()
            .ToTable("product_price")
            .HasOne(p => p.Product)
            .WithMany(p => p.PriceHistory)
            .HasForeignKey(p => p.ProductId);
        
        builder
            .Entity<RedDotSight>()
            .HasOne(r => r.Manufacturer)
            .WithMany(m => m.RedDotSights)
            .HasForeignKey(r => r.ManufacturerId);
        
        builder
            .Entity<Rifle>()
            .HasOne(r => r.Manufacturer)
            .WithMany(m => m.Rifles)
            .HasForeignKey(r => r.ManufacturerId);
        builder
            .Entity<Rifle>()
            .HasOne(r => r.RifleActionType)
            .WithMany(m => m.Rifles)
            .HasForeignKey(r => r.RifleActionTypeId);
        
        builder
            .Entity<RifleActionType>()
            .ToTable("rifle_action_type");
        
        builder
            .Entity<SafetyType>()
            .ToTable("safety_type");
        
        builder
            .Entity<Scope>()
            .HasOne(s => s.Manufacturer)
            .WithMany(m => m.Scopes)
            .HasForeignKey(s => s.ManufacturerId);
        builder
            .Entity<Scope>()
            .OwnsOne(s => s.FovRange, f =>
            {
                f.Property(p => p.FovInFeetAtZeroYards);
                f.Property(p => p.FovInFeetAtOneHundredYards);
            })
            .OwnsOne(s => s.MagnificationRange, s =>
            {
                s.Property(p => p.MinMagnification);
                s.Property(p => p.MaxMagnification);
            });
        
        builder
            .Entity<Seller>()
            .ToTable("seller")
            .OwnsOne(s => s.Address, a =>
            {
                a.Property(p => p.AddressLine);
                a.Property(p => p.City);
                a.Property(p => p.State);
                a.Property(p => p.Country);
                a.Property(p => p.PostalCode);
            });

        builder
            .Entity<Set>()
            .ToTable("set");
            
        builder
            .Entity<ShoppingCart>()
            .HasOne(s => s.Customer)
            .WithOne(c => c.ShoppingCart)
            .HasForeignKey<ShoppingCart>(s => s.CustomerId);
        
        builder
            .Entity<Shotgun>()
            .HasOne(s => s.Manufacturer)
            .WithMany(m => m.Shotguns)
            .HasForeignKey(s => s.ManufacturerId);
        builder
            .Entity<Shotgun>()
            .HasOne(s => s.ShotgunActionType)
            .WithMany(s => s.Shotguns)
            .HasForeignKey(s => s.ShotgunActionTypeId);
        
        builder
            .Entity<ShotgunActionType>()
            .ToTable("shotgun_action_type");
    }
}
