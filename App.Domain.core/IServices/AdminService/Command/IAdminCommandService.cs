

using Eshop.Domain.core.Dtos;

namespace EShop.Domain.core.IServices.AdminService.Command
{
    public interface IAdminCommandService
    {
         Task<bool> EditeProfile(AdminEditDto admineditdto);
    }
}
