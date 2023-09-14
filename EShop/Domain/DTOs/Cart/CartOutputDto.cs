using EShop.Domain.Entity;

namespace EShop.Domain.DTOs.Cart
{
    public class CartOutputDto
    {
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
