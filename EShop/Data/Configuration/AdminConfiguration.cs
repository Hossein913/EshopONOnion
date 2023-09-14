using EShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EShop.Data.Configuration
{
    public class AdminConfiguration: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(a => a.Id).ValueGeneratedNever();
        }
    }
}
