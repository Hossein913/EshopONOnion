

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly IQueryable _queryable;
        public CategoryRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }
}
