

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private readonly IQueryable _queryable;
        public CartRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }
}
