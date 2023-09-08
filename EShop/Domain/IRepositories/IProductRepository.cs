using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
{
    public interface IProductRepository
    {
        Task Create(Product product);
        Task Update(Product product);
        Task Delete(int productId);
        Task<Product> GetById(int productId);
        Task<List<Product>> GetAll();
    }
}
