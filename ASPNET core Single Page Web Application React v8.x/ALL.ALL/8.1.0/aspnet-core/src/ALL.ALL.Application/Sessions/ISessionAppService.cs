using System.Threading.Tasks;
using Abp.Application.Services;
using ALL.ALL.Sessions.Dto;

namespace ALL.ALL.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
