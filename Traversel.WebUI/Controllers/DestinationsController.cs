using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversel.WebUI.Controllers
{
    public class DestinationsController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
