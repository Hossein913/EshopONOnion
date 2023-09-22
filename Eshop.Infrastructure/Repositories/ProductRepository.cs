

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IQueryable _queryable;
        public ProductRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }
}
