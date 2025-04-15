using Microsoft.AspNetCore.Mvc;

namespace Traversel.WebUI.ViewComponents.LandingPage
{
    public class StatisticsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
