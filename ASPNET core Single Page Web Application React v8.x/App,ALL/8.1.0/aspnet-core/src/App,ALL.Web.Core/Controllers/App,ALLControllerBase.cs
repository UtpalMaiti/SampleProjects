using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace App,ALL.Controllers
{
    public abstract class App,ALLControllerBase: AbpController
    {
        protected App,ALLControllerBase()
        {
            LocalizationSourceName = App,ALLConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
