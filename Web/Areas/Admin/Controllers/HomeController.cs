using Microsoft.AspNetCore.Mvc;
using Web.Attributes;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [RedirectToLoginIfNotAuthorized]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
