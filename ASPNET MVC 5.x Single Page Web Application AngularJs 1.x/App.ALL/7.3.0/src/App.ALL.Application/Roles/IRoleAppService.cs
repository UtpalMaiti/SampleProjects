using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.ALL.Roles.Dto;

namespace App.ALL.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
