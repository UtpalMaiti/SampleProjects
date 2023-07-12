using System.Threading.Tasks;
using Abp.Application.Services;
using App.ALL.Sessions.Dto;

namespace App.ALL.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
