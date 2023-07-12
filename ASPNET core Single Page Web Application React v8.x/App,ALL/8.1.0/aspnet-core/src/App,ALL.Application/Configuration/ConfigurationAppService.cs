using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using App,ALL.Configuration.Dto;

namespace App,ALL.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : App,ALLAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
