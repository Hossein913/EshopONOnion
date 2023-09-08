using EShop.Domain.DTOs.Category;
using EShop.Domain.IRepositories;
using EShop.ViewModels.Category;

namespace EShop.Domain.IServices.CategoryService.Queries
{
    public class CategoryQueryService : ICategoryQueryService
    {
        private readonly ICategoryRepository repository;

        public CategoryQueryService(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<CategoryViewModel>> GetAllCategory()
        {
            var categores = await repository.GetAll();

            List<CategoryViewModel> categoryOutputDto = categores.Select( x => new CategoryViewModel() { 
                Id= x.Id,
                Name= x.Name,
                Description= x.Description
            }).ToList();

            return categoryOutputDto;
        }
    }
}
