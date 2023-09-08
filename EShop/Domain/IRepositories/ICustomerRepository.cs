using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
{
    public interface ICustomerRepository
    {
        Task<Customer> Create(Customer customer);
        Task Update(Customer customer);
        Task Delete(int customerId);
        Task<Customer?> GetById(int customerId);
        Task<List<Customer>> GetAll();
    }
}
