using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Configuration
{
    public class PictureConfiguration: IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasOne(pc => pc.Product)
                .WithMany(pr => pr.Pictures)
                .HasForeignKey(pc => pc.ProductId);
        }
    }
}
