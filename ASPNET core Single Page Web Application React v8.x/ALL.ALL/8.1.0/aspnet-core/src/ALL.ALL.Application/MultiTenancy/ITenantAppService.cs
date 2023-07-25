using Abp.Application.Services;
using ALL.ALL.MultiTenancy.Dto;

namespace ALL.ALL.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

