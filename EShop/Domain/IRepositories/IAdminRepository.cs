using EShop.Domain.DTOs;
using EShop.Domain.DTOs.Customer;
using EShop.Domain.Entity;

namespace EShop.Domain.IRepositories
{
    public interface IAdminRepository
    {
        Task<Admin> Create(AdminAddDto adminDto);
        Task Update(AdminAddDto adminDto);
        Task Delete(int AdminId);
        Task<Admin?> GetById(int AdminId);
        Task<List<Admin>> GetAll();
    }
}
