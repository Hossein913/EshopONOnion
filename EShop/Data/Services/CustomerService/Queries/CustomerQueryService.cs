using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;
using EShop.Domain.IServices.CustomerService.Command;

namespace EShop.Domain.IServices.CustomerService.Queries
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

