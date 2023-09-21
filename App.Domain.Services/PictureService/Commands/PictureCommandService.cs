
using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos.Pictures;
using Eshop.Domain.core.IServices.PictureService.Commands;

namespace EShop.Domain.Services.PictureService.Commands
{
    public class PictureCommandService : IPictureCommandService
    {
        protected readonly IPictureRepository _pictureRepository;
        public PictureCommandService(IPictureRepository pictureRepository)
        {
          _pictureRepository = pictureRepository;
        }

        public async Task CreatePicture(PictureAddDto Picture)
        {
            _pictureRepository.Create(Picture);
        }

        public async Task<bool> DeletePicture(int PictureId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EditPicture(PictureEditDto Picture)
        {
            throw new NotImplementedException();
        }
    }
}
