using Eshop.Domain.core.AppService;
using Eshop.Domain.core.Dtos.Category;
using EShop.Domain.core.IServices.CategoryService.Command;
using Eshop.Domain.core.IServices.FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace EShop.Domain.AppServices.CategoryAppServce
{
    public  class CategoryAppServices : ICategoriAppServices
    {
        protected readonly ICategoryCommandService _categoryCommandService;
        private readonly IFileServices _fileServices;

        public async Task CreateCategory(CategoryAddDto categoryAddDto, IFormFile PhotFile, string UploadPath)
        {

            var fileNameWithoutExtension = DateTime.Now.Ticks.ToString();

        }

        public async Task EditeCategory(CategoryEditDto categoryEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
