

namespace EShop.Domain.core.IServices.CategoryService.Queries
{
    public interface ICategoryQueryService
    {
        Task<List<CategoryViewModel>> GetAllCategory();
    }
}
