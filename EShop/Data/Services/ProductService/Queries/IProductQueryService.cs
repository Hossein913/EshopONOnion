using EShop.Domain.DTOs.Products;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.ProductService.Queries
{
    public class ProductQueryService : IProductQueryService
    {
        public Task<List<ProductOutPutDto>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOutPutDto>> GetProductsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOutPutDto>> SeachInProduct(string name)
        {
            throw new NotImplementedException();
        }
    }
}
