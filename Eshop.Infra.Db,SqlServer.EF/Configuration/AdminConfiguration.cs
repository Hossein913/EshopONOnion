

using Eshop.Domain.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eshop.Infra.Db_SqlServer.EF.Configuration
{
    public class AdminConfiguration: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(a => a.Id).ValueGeneratedNever();
        }
    }
}
