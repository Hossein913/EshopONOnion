

using Eshop.Domain.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infra.Db_SqlServer.EF.Configuration
{
    public class OrderConfiguration: IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasOne(o => o.Cart)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CartId);

            builder.HasOne(o => o.Product)
              .WithOne(c => c.Order)
              .HasForeignKey<Order>(o => o.ProductId);

        }
    }
}
