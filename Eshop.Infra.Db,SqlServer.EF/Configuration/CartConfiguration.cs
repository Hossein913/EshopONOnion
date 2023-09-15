
using Eshop.Domain.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infra.Db_SqlServer.EF.Configuration
{
    public class CartConfiguration: IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasOne(cr => cr.Customers)
                .WithMany(c => c.Carts)
                .HasForeignKey(cr => cr.CustomerId);


        }
    }
}
