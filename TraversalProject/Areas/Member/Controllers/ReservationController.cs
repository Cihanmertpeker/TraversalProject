using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());
        ReservationManager reservationManager = new(new EfReservationDal());
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        public IActionResult MyOldReservation()
        {
            return View();
        }

        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetlist()
                                           select new SelectListItem
                                           {
                                               Text= x.City,
                                               Value=x.DestinationId.ToString(),
                                           }).ToList();
            ViewBag.v=values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            reservationManager.Tadd(p);
            return RedirectToAction("MyCurrenReservation");
        }
    }
}
