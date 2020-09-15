using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using StudentMS.Controllers;

namespace StudentMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : StudentMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
