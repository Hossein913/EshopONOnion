
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Entities;
using Eshop.Infra.Db_SqlServer.EF;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Repos.Ef
{   
    public class CategoryRepository : ICategoryRepository
    {

        private readonly EshopContext _context;
        public CategoryRepository(EshopContext eshopContext)
        {
            _context = eshopContext;
        }

        public async Task<int> Create(CategoryAddDto categoryAddDto)
        {
            Category category = new Category
            {
                Name = categoryAddDto.Name,
                Description = categoryAddDto.Description,
                IsDeleted = false
            };
            await _context.Categories.AddAsync(category);
            var result = await _context.SaveChangesAsync();
            if (result != 0) 
                return category.Id;

            return 0;
        }   

        public async Task Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            category.IsDeleted = true;
            int number = await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryOutputDto>> GetAll()
        {
            return await _context.Categories.AsNoTracking().Select<Category,CategoryOutputDto>(c => new CategoryOutputDto
            {
                 Id = c.Id, Name = c.Name, Description = c.Description, Photo = c.Picture.PictureLink
            }).ToListAsync(); 
        }

        public async Task<Category> GetById(int categoryId)
        {
            return await _context.Categories.FindAsync(categoryId);
        }

        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
            int number = await _context.SaveChangesAsync();
        }
    }
}   
