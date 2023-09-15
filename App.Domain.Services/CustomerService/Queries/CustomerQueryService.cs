
using Eshop.Domain.core.Dtos.Customer;
using EShop.Domain.core.IServices.CustomerService.Command;

namespace EShop.Domain.Services.CustomerService.Queries
{
    public class CustomerQueryService : ICustomerCommandService
    {
        public Task<bool> AddPicture(int PictureId, int item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EditProfile(CustomerEditDto customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> PayByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}

