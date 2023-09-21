
using Eshop.Domain.core.Dtos.Category;

namespace EShop.Domain.core.IServices.CategoryService.Command
{
    public interface ICategoryCommandService
    {
        Task<int> CreateCategory(CategoryAddDto category);
        Task<bool> EditCategory(CategoryEditDto category);
        Task<bool> DeleteCategory(int catrguryId);
    }
}
