using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly EshopContext _context;

        public CustomerRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<Customer> Create(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task Delete(int customerId)
        {
            var customer = await _context.Customers.FindAsync(customerId);
            customer.IsDeleted = true;
            await _context.SaveChangesAsync();

        }

        public async Task<List<Customer>> GetAll()
        {
            var customer = _context.Customers.AsNoTracking().Include(c => c.IdNavigation);
            return customer.ToList();
        }

        public async Task<Customer?> GetById(int customerId)
        {
            var product = await _context.Customers.FirstOrDefaultAsync(p => p.Id == customerId);
            return product;
        }

        public async Task Update(Customer customer)
        {
            //var entity = _context.Customers.Find(customer.Id);
            //entity.Name = customer.Name;
            //entity.LastName = customer.LastName;
            //entity.Address = customer.Address;
            _context.Entry(customer).State = EntityState.Modified;
        }
    }

}