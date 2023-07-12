using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace App.ALL.Web.Views
{
    public abstract class ALLRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ALLRazorPage()
        {
            LocalizationSourceName = ALLConsts.LocalizationSourceName;
        }
    }
}
