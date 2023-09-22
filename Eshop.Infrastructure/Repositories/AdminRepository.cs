

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        protected AdminRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }

}