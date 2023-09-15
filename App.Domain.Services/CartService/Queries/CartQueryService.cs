

using Eshop.Domain.core.Dtos.Cart;
using EShop.Domain.core.IServices.CartService.Queries;

namespace EShop.Domain.IServices.CartService.Queries
{
    public class CartQueryService : ICartQueryService
    {
        public Task<CartOutputDto> ReadByCartId(int CartId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CartOutputDto>> ReadPaiedCustomerId(int CustomerId)
        {
            throw new NotImplementedException();
        }
    }
}
