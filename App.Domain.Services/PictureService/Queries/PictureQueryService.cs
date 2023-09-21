using Eshop.Domain.core.Dtos.Category;
using Eshop.Domain.core.Dtos.Pictures;
using Eshop.Domain.core.IServices.PictureService.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Services.PictureService.Queries
{
    public  class PictureQueryService : IPictureQueryService
    {
        public async Task<PictureOutPutDto> GetbyForigenKeyId()
        {
            throw new NotImplementedException();
        }
    }
}
