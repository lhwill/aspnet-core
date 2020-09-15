using System.Threading.Tasks;
using StudentMS.Configuration.Dto;

namespace StudentMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
