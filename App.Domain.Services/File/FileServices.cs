using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Domain.core.IServices.FileService;
using Microsoft.AspNetCore.Http;

namespace EShop.Domain.Services.File
{
    public class FileServices : IFileServices
    {

        public async Task<string> FileUploadAsync(string FileNewName,string uploadPath,IFormFile file)
        {
            

            if (!Directory.Exists(uploadPath))
            {
                Directory.CreateDirectory(uploadPath);
            }

            // Get the original file extension
            var fileExtension = Path.GetExtension(file.FileName);

            // Construct the new file name
            var fileFullName = FileNewName + fileExtension;

            var filePath = Path.Combine(uploadPath, fileFullName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filePath
        }

        public Task<bool> FileDeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> FileExistsAsync(string path)
        {
            throw new NotImplementedException();
        }

        public Task<bool> FileUpdateAsync()
        {
            throw new NotImplementedException();
        }

    }
}
