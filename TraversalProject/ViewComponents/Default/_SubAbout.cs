using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new(new EfSubAboutDal());

        public IViewComponentResult Invoke()
        {
           var values = subAboutManager.TGetlist();

           return View(values);
        }
    }
}
