
using Eshop.Domain.core.Dtos.Customer;
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
{
    public interface ICustomerRepository
    {
        Task<Customer> Create(CustomerAddDto customer);
        Task Update(CustomerAddDto customer);
        Task Delete(int customerId);
        Task<Customer?> GetById(int customerId);
        //Task<List<Customer>> GetAll();
    }
}
