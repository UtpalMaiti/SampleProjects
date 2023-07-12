using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace App.ALL.Controllers
{
    public abstract class ALLControllerBase: AbpController
    {
        protected ALLControllerBase()
        {
            LocalizationSourceName = ALLConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
