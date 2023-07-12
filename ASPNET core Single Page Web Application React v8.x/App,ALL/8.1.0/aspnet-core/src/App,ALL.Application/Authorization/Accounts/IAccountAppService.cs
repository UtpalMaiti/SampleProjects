using System.Threading.Tasks;
using Abp.Application.Services;
using App,ALL.Authorization.Accounts.Dto;

namespace App,ALL.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
