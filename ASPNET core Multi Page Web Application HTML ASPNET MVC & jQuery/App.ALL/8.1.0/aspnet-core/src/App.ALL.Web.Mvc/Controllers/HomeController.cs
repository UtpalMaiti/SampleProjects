using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using App.ALL.Controllers;

namespace App.ALL.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ALLControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
