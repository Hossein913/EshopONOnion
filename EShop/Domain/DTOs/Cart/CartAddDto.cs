namespace EShop.Domain.DTOs.Cart
{
    public class CartAddDto
    {
        public int? Quntity { get; set; }

        public int CustomerId { get; set; }

        public bool? IsPaied { get; set; }
    }
}
