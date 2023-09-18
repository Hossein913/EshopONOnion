using Eshop.Domain.core.AppService;
using Eshop.Domain.core.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices.ProductAppService
{
    public class ProductAppServices : IProductAppservices
    {
        public Task CreateProduct(ProductAddDto productAddDto)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProduct(ProductEditDto productEditDto)
        {
            throw new NotImplementedException();
        }
    }
}
