using System.Threading.Tasks;
using Abp.Application.Services;
using MalamuleleHealth.Sessions.Dto;

namespace MalamuleleHealth.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
