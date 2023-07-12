using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using App.ALL.Controllers;

namespace App.ALL.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ALLControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
