using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.CustomerService.Command
{
    public class CustomerCommandService : ICustomerCommandService
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
