

using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.Dtos.Cart
{
    public class CartOutputDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
