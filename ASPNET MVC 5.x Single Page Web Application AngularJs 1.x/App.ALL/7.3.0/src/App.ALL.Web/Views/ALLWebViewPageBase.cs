using Abp.Web.Mvc.Views;

namespace App.ALL.Web.Views
{
    public abstract class ALLWebViewPageBase : ALLWebViewPageBase<dynamic>
    {

    }

    public abstract class ALLWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ALLWebViewPageBase()
        {
            LocalizationSourceName = ALLConsts.LocalizationSourceName;
        }
    }
}