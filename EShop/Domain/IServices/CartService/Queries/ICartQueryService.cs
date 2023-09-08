using EShop.Domain.DTOs.Cart;

namespace EShop.Domain.IServices.CartService.Queries
{
    public interface ICartQueryService
    {
        Task<CartOutputDto> ReadByCartId(int CartId);
        Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId);
    }
}
