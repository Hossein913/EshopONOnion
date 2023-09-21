

using Eshop.Domain.core.DataAccess.EfRipository;
using Eshop.Domain.core.Dtos;
using Eshop.Domain.core.Dtos.Pictures;
using Eshop.Domain.core.Entities;
using Eshop.Infra.Db_SqlServer.EF;
using Microsoft.EntityFrameworkCore;

namespace Eshop.Infra.Data.Repos.Ef
{
    public class PictureRepository : IPictureRepository
    {
        protected readonly EshopContext _context;
        public PictureRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<GeneralDto<bool>> Create(PictureAddDto pictureAddDto)
        {
            Picture picture = new Picture() 
            { 
                 PictureLink = pictureAddDto.PictureLinkAddress,
                 CategoriId = pictureAddDto.CategoryId,
                 ProductId = pictureAddDto.ProductId
            };
            await _context.Pictures.AddAsync(picture);
           int result =  await _context.SaveChangesAsync();
            bool boolResult = result > 0;
            return new GeneralDto<bool> { Id="" , Data = boolResult };

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
