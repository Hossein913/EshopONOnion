
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface ICartRepository
    {
        Task Create(Cart cart);
        Task Update(Cart cart);
        Task Delete(int cartId);
        Task<Cart> GetById(int cartId);
        Task<List<Cart>> GetAll();
    }
}
