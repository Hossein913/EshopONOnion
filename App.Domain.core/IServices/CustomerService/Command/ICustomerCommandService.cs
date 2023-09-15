

using Eshop.Domain.core.Dtos.Customer;

namespace EShop.Domain.core.IServices.CustomerService.Command
{
    public interface ICustomerCommandService
    {
        Task<bool> EditProfile(CustomerEditDto customer);
        Task<bool> PayByCustomerId(int customerId);
        Task<bool> AddPicture(int PictureId, int item);
    }
}
