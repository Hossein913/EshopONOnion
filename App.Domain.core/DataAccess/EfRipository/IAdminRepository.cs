
using Eshop.Domain.core.Dtos.Admin;
using Eshop.Domain.core.Entities;

namespace Eshop.Domain.core.DataAccess.EfRipository
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
