using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversel.WebUI.ViewComponents.LandingPage
{
    public class SubAboutViewComponent : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetListAll();
            return View(values);
        }
    }
}
