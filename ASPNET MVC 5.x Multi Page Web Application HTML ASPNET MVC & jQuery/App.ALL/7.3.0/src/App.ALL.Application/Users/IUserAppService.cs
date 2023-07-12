using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.ALL.Roles.Dto;
using App.ALL.Users.Dto;

namespace App.ALL.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}