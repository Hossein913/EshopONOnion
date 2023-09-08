using EShop.Domain.DTOs;
using EShop.Domain.Entity;

namespace EShop.Domain.IServices.AdminService.Command
{
    public interface IAdminCommandService
    {
         Task<bool> EditeProfile(AdminEditDto admineditdto);
    }
}
