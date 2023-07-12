using Abp.Application.Services;
using App.ALL.MultiTenancy.Dto;

namespace App.ALL.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

