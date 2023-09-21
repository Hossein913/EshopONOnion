


using Eshop.Domain.core.Dtos.Admin;

namespace EShop.Domain.core.IServices.AdminService.Command
{
    public interface IAdminCommandService
    {
         Task<bool> EditeProfile(AdminEditDto admineditdto);
    }
}
