

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Category;
using EShop.Domain.core.IServices.CategoryService.Command;

namespace EShop.Domain.Services.CategoryService.Command
{
    public class CategoryCommandService : ICategoryCommandService
    {
        protected readonly ICategoryRepository _categoryRepository;
        public CategoryCommandService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> CreateCategory(CategoryAddDto categoryAddDto)
        { 
           var categoryId = await _categoryRepository.Create(categoryAddDto);
            return categoryId;
        }

        public Task<bool> DeleteCategory(int catrguryId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditCategory(CategoryEditDto category)
        {
            throw new NotImplementedException();
        }
    }
}
