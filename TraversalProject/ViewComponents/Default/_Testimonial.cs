using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
