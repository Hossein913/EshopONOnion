
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface ICategoryRepository
    {
        Task     Create(Category category);
        Task Update(Category category);
        Task Delete(int categoryId);
        Task<Category> GetById(int categoryId);
        Task<List<Category>> GetAll();
    }
}
