using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

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