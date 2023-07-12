using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.ALL.MultiTenancy.Dto;

namespace App.ALL.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
