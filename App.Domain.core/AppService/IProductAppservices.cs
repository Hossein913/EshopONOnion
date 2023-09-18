using Eshop.Domain.core.Dtos.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.core.AppService
{
    public interface IProductAppservices
    {
        Task CreateProduct(ProductAddDto productAddDto);
        Task UpdateProduct(ProductEditDto productEditDto);
    }
}
