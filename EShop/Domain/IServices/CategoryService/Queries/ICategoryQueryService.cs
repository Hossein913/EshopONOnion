using EShop.Domain.DTOs.Category;

namespace EShop.Domain.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryOutputDto>> GetAllCategory();
    }
}
