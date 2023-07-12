using System.Threading.Tasks;
using App,ALL.Configuration.Dto;

namespace App,ALL.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
