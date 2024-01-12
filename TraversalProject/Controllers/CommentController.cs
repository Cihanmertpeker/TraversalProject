using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace TraversalProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commendService;

        public CommentController(ICommentService commendService)
        {
            _commendService = commendService;
        }

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
            _commendService.Tadd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
