using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Pictures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.core.IServices.PictureService.Queries
{
    public interface IPictureQueryService
    {
            Task<PictureOutPutDto> GetbyForigenKeyId();
    }
}
