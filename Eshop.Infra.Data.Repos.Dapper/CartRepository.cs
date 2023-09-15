
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Entities;
using Eshop.Infra.Db_SqlServer.EF;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Repos.Ef
{
    public class CartRepository : ICartRepository
    {
        private readonly EshopContext _context;

        public CartRepository(EshopContext context)
        {
            _context = context;
        }
        public async Task Create(Cart cart)
        {
            await _context.Carts.AddAsync(cart);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int cartId)
        {
            var category = await _context.Carts.FindAsync(cartId);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
        }

        public Task<List<Cart>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Cart> GetById(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
