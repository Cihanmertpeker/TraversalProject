using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetlist();

            return View(values);
        }
    }
}
