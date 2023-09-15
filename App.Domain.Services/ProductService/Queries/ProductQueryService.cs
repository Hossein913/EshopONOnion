
using Eshop.Domain.core.Dtos.Products;
using EShop.Domain.core.IServices.ProductService.Queries;

namespace EShop.Domain.Services.ProductService.Queries
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
