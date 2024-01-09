﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetlist();
            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values = destinationManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
