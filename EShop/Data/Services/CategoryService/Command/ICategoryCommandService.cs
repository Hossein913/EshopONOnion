using EShop.Domain.DTOs.Category;

namespace EShop.Domain.IServices.CategoryService.Command
{
    public class CategoryCommandService : ICategoryCommandService
    {
        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateCategory(CategoryAddDto category)
        {
            throw new NotImplementedException();
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
