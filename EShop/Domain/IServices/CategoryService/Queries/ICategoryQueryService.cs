using EShop.Domain.DTOs.Category;
using EShop.ViewModels.Category;

namespace EShop.Domain.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryViewModel>> GetAllCategory();
    }
}
