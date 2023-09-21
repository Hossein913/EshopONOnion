
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface ICategoryRepository
    {
        Task<int> Create(CategoryAddDto category);
        Task Update(Category category);
        Task Delete(int categoryId);
        Task<Category> GetById(int categoryId);
        Task<List<CategoryOutputDto>> GetAll();
    }
}
