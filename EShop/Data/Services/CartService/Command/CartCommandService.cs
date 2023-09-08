using EShop.Domain.DTOs;

namespace EShop.Domain.IServices.CartService.Command
{
    public class CartCommandService : ICartCommandService
    {
        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCart(int CustomerId, int CartId)
        {
            throw new NotImplementedException();
        }
    }
}
