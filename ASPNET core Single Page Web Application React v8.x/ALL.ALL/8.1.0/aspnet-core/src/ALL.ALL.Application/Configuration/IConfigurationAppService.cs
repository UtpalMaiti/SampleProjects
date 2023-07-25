using System.Threading.Tasks;
using ALL.ALL.Configuration.Dto;

namespace ALL.ALL.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
