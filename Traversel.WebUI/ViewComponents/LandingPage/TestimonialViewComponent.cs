using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversel.WebUI.ViewComponents.LandingPage
{
    public class TestimonialViewComponent : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetListAll();
            return View(values);
        }
    }
}
