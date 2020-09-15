using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using StudentMS.Configuration.Dto;

namespace StudentMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StudentMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
