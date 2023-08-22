using Abp.Application.Services;
using MalamuleleHealth.MultiTenancy.Dto;

namespace MalamuleleHealth.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

