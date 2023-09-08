using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Picture;
using EShop.Domain.IRepositories;

namespace EShop.Data.Repository
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
