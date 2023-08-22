using System.Threading.Tasks;
using Abp.Application.Services;
using MalamuleleHealth.Authorization.Accounts.Dto;

namespace MalamuleleHealth.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
