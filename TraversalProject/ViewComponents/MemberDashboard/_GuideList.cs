using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        GuideManager guideManager = new(new EfGuideDal());
        
        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetlist();

            return View(values);
        }
    }
}
