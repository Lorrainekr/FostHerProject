using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class EventController : Controller
    {
        public IActionResult IndexEvent()
        {
            using (IDal dal = new Dal())
            {
                List<Event> eve = dal.ListAllEvents(); 
                ViewBag.listEvents = eve;
            }
            return View();
        }

        public IActionResult CartEvent(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Event eve = dal.ListAllEvents().Where(r => r.Id == id).FirstOrDefault();
                    if (eve == null)
                    {
                        return View("Error");
                    }
                    return View(eve);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult CartEvent(Event eve)
        {
            if (!ModelState.IsValid)
                return View(eve);

            if (eve.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                  
                    ctx.AddToCart(eve);

                    return RedirectToAction("IndexEvent");
                }
            }
            else
            {
                return View("Error");
            }
        }
    }
}
