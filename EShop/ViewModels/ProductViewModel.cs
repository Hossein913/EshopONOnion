namespace EShop.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int CategoryId { get; set; }

        public int? Quntity { get; set; }

        public string? Photo { get; set; }

        public IFormFile? PhotoFile { get; set; }
    }
}
