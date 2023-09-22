

using Eshop.Domain.Entities;
using Eshop.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infrastructure.Repositories
{
    public class PictureRepository : Repository<Picture>, IPictureRepository
    {
        private readonly IQueryable _queryable;
        public PictureRepository(EshopContext dbContext) : base(dbContext)
        {
        }
    }
}
