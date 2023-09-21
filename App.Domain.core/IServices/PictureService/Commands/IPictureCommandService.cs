using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Pictures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.core.IServices.PictureService.Commands
{
    public interface IPictureCommandService
    {
        Task CreatePicture(PictureAddDto Picture);
        Task<bool> EditPicture(PictureEditDto Picture);
        Task<bool> DeletePicture(int PictureId);
    }
}
