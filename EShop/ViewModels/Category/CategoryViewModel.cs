namespace EShop.ViewModels.Category
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string? Photo { get; set; }

        public IFormFile? PhotoFile { get; set; }
    }
}
