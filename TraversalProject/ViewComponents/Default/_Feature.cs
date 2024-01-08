using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
           // ViewBag.image1 = featureManager.TGetById();

            return View();
        }
    }
}
