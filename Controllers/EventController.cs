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
                ViewBag.listEvenements = eve;
            }
            return View();
        }
    }
}
