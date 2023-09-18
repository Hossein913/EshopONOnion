using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.core.IServices.FileService
{
    public interface IFileServices
    {
        Task<string> FileUploadAsync(string FileNewName, string uploadPath, IFormFile file);
        Task<bool> FileExistsAsync(string path);
        Task<bool> FileUpdateAsync();
        Task<bool> FileDeleteAsync();

    }
}
