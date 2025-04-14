using Microsoft.AspNetCore.Mvc;

namespace Traversel.WebUI.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
