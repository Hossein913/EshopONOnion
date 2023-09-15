

using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.Dtos.Category
{
    public class CategoryOutputDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public IList<Product>? Products { get; set; }
    }
}

