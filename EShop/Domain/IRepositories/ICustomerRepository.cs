using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
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
