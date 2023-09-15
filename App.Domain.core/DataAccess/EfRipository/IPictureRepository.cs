
using Eshop.Domain.core.Dtos;
using Eshop.Domain.core.Dtos.Pictures;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface IPictureRepository
    {
        Task<GeneralDto<bool>> Create(PictureAddDto picture);
        Task<GeneralDto<bool>> Update(PictureEditDto picture);
        Task<GeneralDto<bool>> Delete(int pictureId);
        Task<GeneralDto<PictureOutPutDto>> GetById(int pictureId);
        Task<GeneralDto<List<PictureOutPutDto>>> GetAll();
    }
}
