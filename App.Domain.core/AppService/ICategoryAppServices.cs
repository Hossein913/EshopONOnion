using Eshop.Domain.core.Dtos.Category;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.core.AppService
{
    public interface ICategoryAppServices
    {
        Task CreateCategory(CategoryAddDto categoryAddDto, IFormFile PhotFile, string UploadPath);
        Task EditeCategory(CategoryEditDto categoryEditDto);
    }
}
