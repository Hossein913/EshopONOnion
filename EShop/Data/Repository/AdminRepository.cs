using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Category;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;
using EShop.Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data.Repository
{
    public class AdminRepository : IAdminRepository
    {

        private readonly EshopContext _context;

        public AdminRepository(EshopContext context)
        {
            _context = context;
        }

        public async Task<Admin> Create(AdminAddDto AdminDto)
        {
            Admin admin = new Admin()
            {
                Id = AdminDto.Id,
                Name = AdminDto.FirstName,
                LastName = AdminDto.LastName, 
            };
            await _context.Admins.AddAsync(admin);
            await _context.SaveChangesAsync();
            return admin;
        }

        public async Task Delete(int AdminId)
        {
            throw new NotImplementedException();


            //var customer = await _context.Customers.FindAsync(customerId);
            //customer.IsDeleted = true;
            //await _context.SaveChangesAsync();

        }

        public async Task<List<Admin>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Admin?> GetById(int AminId)
        {
            throw new NotImplementedException();


            //var product = await _context.Customers.FirstOrDefaultAsync(p => p.Id == customerId);
            //return product;
        }

        public async Task Update(AdminAddDto AdminDto)
        {
            throw new NotImplementedException();


            //var entity = _context.Customers.Find(customer.Id);
            //entity.Name = customer.Name;
            //entity.LastName = customer.LastName;
            //entity.Address = customer.Address;
            //_context.Entry(customer).State = EntityState.Modified;
        }
    }

}