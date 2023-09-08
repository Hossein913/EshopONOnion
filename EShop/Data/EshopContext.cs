using System;
using System.Collections.Generic;
using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace EShop.Data;

public partial class EshopContext : IdentityDbContext<User, Role, string>
{

    public EshopContext(DbContextOptions<EshopContext> options): base(options)
    {
    }

    public DbSet<Admin> Admins { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<Customer> Customers { get; set; }


    public  DbSet<Picture> Pictures { get; set; }

    public  DbSet<Product> Products { get; set; }


    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => base.OnConfiguring(optionsBuilder);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admins");

            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PersonalCode).HasMaxLength(50);
        });

        //modelBuilder.Entity<Cart>(entity =>
        //{
        //    entity.ToTable("Carts");

        //    //entity.Property(e => e.Id).ValueGeneratedNever();
        //    entity.Property(e => e.CustomerId).ValueGeneratedOnAdd();
        //});

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Categories");

            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        //modelBuilder.Entity<CategoryProduct>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("CategoryProduct");

        //    entity.HasOne(d => d.Category).WithMany()
        //        .HasForeignKey(d => d.CategoryId)
        //        .HasConstraintName("FK_CategoryProduct_Category");

        //    entity.HasOne(d => d.Product).WithMany()
        //        .HasForeignKey(d => d.ProductId)
        //        .HasConstraintName("FK_CategoryProduct_Product");
        //});

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customers");

            //entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Customer)
                .HasForeignKey<Customer>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customer_Cart");
        });

        modelBuilder.Entity<Picture>(entity =>
        {
            entity.ToTable("Pictures");

            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.LinsAddress).HasMaxLength(250);

            entity.HasOne(d => d.Product).WithMany(p => p.Pictures)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Picture_Product");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Products");

            //entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
        });

        //modelBuilder.Entity<ProductCart>(entity =>
        //{
        //    entity
        //        .HasNoKey()
        //        .ToTable("ProductCart");

        //    entity.HasOne(d => d.Cart).WithMany()
        //        .HasForeignKey(d => d.CartId)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_ProductCart_Cart");

        //    entity.HasOne(d => d.Product).WithMany()
        //        .HasForeignKey(d => d.ProductId)
        //        .OnDelete(DeleteBehavior.ClientSetNull)
        //        .HasConstraintName("FK_ProductCart_Product");
        //});

        base.OnModelCreating(modelBuilder);
    }


}
