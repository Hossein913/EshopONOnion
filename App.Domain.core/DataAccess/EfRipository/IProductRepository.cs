
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
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
