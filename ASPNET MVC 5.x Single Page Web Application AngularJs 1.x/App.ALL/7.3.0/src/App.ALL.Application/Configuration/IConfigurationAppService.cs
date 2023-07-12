using System.Threading.Tasks;
using Abp.Application.Services;
using App.ALL.Configuration.Dto;

namespace App.ALL.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}