using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ALL.ALL.Configuration.Dto;

namespace ALL.ALL.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ALLAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
