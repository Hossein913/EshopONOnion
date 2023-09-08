using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
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
