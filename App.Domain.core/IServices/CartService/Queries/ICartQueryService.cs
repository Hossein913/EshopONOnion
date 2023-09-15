
using Eshop.Domain.core.Dtos.Cart;

namespace EShop.Domain.core.IServices.CartService.Queries
{
    public interface ICartQueryService
    {
        Task<CartOutputDto> ReadByCartId(int CartId);
        Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId);
    }
}
