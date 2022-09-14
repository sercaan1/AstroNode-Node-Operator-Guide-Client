using Microsoft.AspNetCore.Mvc;
using Web.Attributes;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        [RedirectToLoginIfNotAuthorized]
        public IActionResult Index()
        {
            return View();
        }
    }
}
