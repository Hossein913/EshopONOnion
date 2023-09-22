

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly IQueryable _queryable;
        public AdminRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }

}