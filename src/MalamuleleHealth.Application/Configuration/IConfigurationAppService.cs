using System.Threading.Tasks;
using MalamuleleHealth.Configuration.Dto;

namespace MalamuleleHealth.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
