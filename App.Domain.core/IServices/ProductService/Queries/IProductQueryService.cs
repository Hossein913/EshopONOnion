
using Eshop.Domain.core.Dtos.Products;

namespace EShop.Domain.core.IServices.ProductService.Queries
{
    public interface IProductQueryService
    {
        Task<List<ProductOutPutDto>> GetAllProducts();
        Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId);
        Task<List<ProductOutPutDto>> SeachInProduct(string name);
    }
}
