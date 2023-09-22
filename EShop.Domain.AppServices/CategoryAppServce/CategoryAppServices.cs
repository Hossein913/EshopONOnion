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
using Eshop.Domain.core.Dtos.Pictures;
using Eshop.Domain.core.IServices.PictureService.Commands;

namespace EShop.Domain.AppServices.CategoryAppServce
{
    public  class CategoryAppServices : ICategoryAppServices
    {
        protected readonly ICategoryCommandService _categoryCommandService;
        protected readonly IPictureCommandService _pictureCommandService ;
        protected readonly IFileServices _fileServices;

        public CategoryAppServices(
            ICategoryCommandService categoryCommandService,
            IPictureCommandService pictureCommandService,
            IFileServices fileServices)
        {
            this._categoryCommandService = categoryCommandService;
            this._pictureCommandService = pictureCommandService;
            _fileServices = fileServices;
        }


        public async Task CreateCategory(CategoryAddDto categoryAddDto, IFormFile PhotFile, string UploadPath)
        {
           var categoryId = await _categoryCommandService.CreateCategory(categoryAddDto);

            var fileNameWithoutExtension = DateTime.Now.Ticks.ToString();

            var FilePath = await _fileServices.FileUploadAsync(fileNameWithoutExtension, UploadPath, PhotFile);

            PictureAddDto pictureAddDto = new PictureAddDto
            {
                CategoryId = categoryId,
                 PictureLinkAddress = FilePath
            };

            await _pictureCommandService.CreatePicture(pictureAddDto);


        }

        public async Task EditeCategory(CategoryEditDto categoryEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
