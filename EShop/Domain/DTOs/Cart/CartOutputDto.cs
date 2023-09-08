using EShop.Domain.Entity;

namespace EShop.Domain.DTOs.Cart
{
    public class CartOutputDto
    {
        public int Id { get; set; }

        public int? Quntity { get; set; }

        public int CustomerId { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
