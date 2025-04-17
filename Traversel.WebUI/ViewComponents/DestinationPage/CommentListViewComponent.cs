using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccessLayer.EntityFramework;

namespace Traversel.WebUI.ViewComponents.DestinationPage
{
    public class CommentListViewComponent : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.TGetDestinationById(id);
            return View(values);
        }
    }
}
