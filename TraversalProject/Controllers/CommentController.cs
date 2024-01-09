using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new(new EfCommentDal());

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;
            p.DestinationId = 3;
            commentManager.Tadd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
