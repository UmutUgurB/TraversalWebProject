using Microsoft.AspNetCore.Mvc;

namespace Traversel.WebUI.ViewComponents.DestinationPage
{
    public class AddCommentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
