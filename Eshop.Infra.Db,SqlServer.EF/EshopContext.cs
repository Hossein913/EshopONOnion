using System;
using System.Collections.Generic;
using Eshop.Domain.core.Entities;
using Eshop.Infra.Db_SqlServer.EF.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Db_SqlServer.EF
{
    public class EshopContext : IdentityDbContext<User, Role, int>
    {
        public EshopContext(DbContextOptions<EshopContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer(" Server=.;Database=Eshop-onion;integrated security=sspi;TrustServerCertificate=True;MultipleActiveResultSets=true ");



        public DbSet<Admin> Admins { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PictureConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }


    }
}
