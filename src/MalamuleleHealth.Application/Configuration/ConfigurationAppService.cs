using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MalamuleleHealth.Configuration.Dto;

namespace MalamuleleHealth.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MalamuleleHealthAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
