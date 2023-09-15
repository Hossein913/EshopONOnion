

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos;
using Eshop.Domain.core.Dtos.Pictures;

namespace Eshop.Infra.Data.Repos.Ef
{
    public class PictureRepository : IPictureRepository
    {
        public Task<GeneralDto<bool>> Create(PictureAddDto picture)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Delete(int pictureId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<List<PictureOutPutDto>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<PictureOutPutDto>> GetById(int pictureId)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralDto<bool>> Update(PictureEditDto picture)
        {
            throw new NotImplementedException();
        }
    }
}
