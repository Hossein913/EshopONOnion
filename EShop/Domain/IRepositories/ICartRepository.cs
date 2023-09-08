using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Cart;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
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
