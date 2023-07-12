using Abp.AspNetCore.Mvc.ViewComponents;

namespace App.ALL.Web.Views
{
    public abstract class ALLViewComponent : AbpViewComponent
    {
        protected ALLViewComponent()
        {
            LocalizationSourceName = ALLConsts.LocalizationSourceName;
        }
    }
}
