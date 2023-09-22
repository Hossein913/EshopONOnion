
using Eshop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            builder.HasOne(p => p.Categories)
                 .WithMany(ct => ct.Products)
                 .HasForeignKey(p => p.CategoryId);
        }
    }
}
