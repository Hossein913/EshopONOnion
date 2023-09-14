namespace EShop.Domain.DTOs
{
    public class GeneralDto<T>
    {
        public string Id { get; set; }
        public T Data { get; set; }
    }
    public class GeneralDto
    {
        public string Id { get; set; }
        public string Data { get; set; }
    }
}
