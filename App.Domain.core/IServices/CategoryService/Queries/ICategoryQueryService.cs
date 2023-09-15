

using Eshop.Domain.core.Dtos.Category;

namespace EShop.Domain.core.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryOutputDto>> GetAllCategory();
    }
}
