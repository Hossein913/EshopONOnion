namespace EShop.Domain.DTOs.Customer
{
    public class CustomerEditDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? LastName { get; set; }

        public bool? IsActive { get; set; }

        public string? Address { get; set; }
    }
}
