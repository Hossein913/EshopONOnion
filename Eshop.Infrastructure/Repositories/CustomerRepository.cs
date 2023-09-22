

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly IQueryable _queryable;
        public CustomerRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }

}