
namespace EShop.Domain.core.IServices.CartService.Command
{
    public interface ICartCommandService
    {
        Task<bool>DeleteCart(int CustomerId , int CartId );
        Task<bool> AddPicture(int PictureId, int item);
    }
}
