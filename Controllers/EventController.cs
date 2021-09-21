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


        public IActionResult CreateEvent(Event eve)
        {
            using (Dal ctx = new Dal())
            {
                if (HttpContext.User.Identity.Name==null) { return View("Error"); }
                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                if (user.artist == null && user.association==null)
                {
                    return View("Error");
                }
            }

            if (!ModelState.IsValid)
                return View(eve);

            using (Dal ctx = new Dal())
            {

                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                if (!(user.artist == null) && (user.artist.Validation == "Valide"))
                {
                    Artist artist = ctx.ListAllArtists().Where(r => r.Id == user.artist.Id).FirstOrDefault();
                    ctx.CreateEvent(eve.Designation, eve.Type, eve.StartDate, eve.EndDate, eve.Price, eve.Category, artist);

                    return View("Modifications");
                }
                else if (!(user.association == null))
                {
                    Association asso = ctx.ListAllAssociations().Where(r => r.Id == user.association.Id).FirstOrDefault();
                    ctx.CreateEvent(eve.Designation, eve.Type, eve.StartDate, eve.EndDate, eve.Price, eve.Category, asso);
                    
                }
                else
                {
                    return View("Error");
                }
            }
            return View("Modifications");
        }
       public IActionResult IndexEvent()
        {
           using (IDal dal = new Dal())
            {
                int a = Int32.Parse(HttpContext.User.Identity.Name);

                User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                if (user == null)
                {
                    ViewBag.user = "B";
                }
                else if (!(user.artist == null) || !(user.association == null))
                {
                    ViewBag.user = "A";
                }
                else
                {
                    ViewBag.user = "B";
                }
                List<Event> eve = dal.ListAllEvents();
               
                ViewBag.listEvents = eve;
                
            }
            return View();
        }

        public IActionResult PageEvent(int id)
        {
            using (IDal dal = new Dal())
            {
                Event eve = dal.ListAllEvents().Where(a => a.Id == id).FirstOrDefault();
                return View(eve);
            }
        }

    }
}











//        public IActionResult CartEvent(int id)
//        {
//            if (id != 0)
//            {
//                using (IDal dal = new Dal())
//                {
//                    Event eve = dal.ListAllEvents().Where(r => r.Id == id).FirstOrDefault();
//                    if (HttpContext.User.Identity.IsAuthenticated)

//                    {
//                        int a = Int32.Parse(HttpContext.User.Identity.Name);
//                        User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
//                        eve.user = user;

//                        if (eve == null)
//                        {
//                            return View("Error");
//                        }
//                        return View(eve);
//                    }
//                }
//                    return View("Error");
//                }
//            return View("Error");
//        }

//        [HttpPost]
//        public IActionResult CartEvent(Event eve)
//        {

//            if (!ModelState.IsValid)
//                return View(eve);

//            if (eve.Id != 0)
//            {
//                using (Dal ctx = new Dal())
//                {


//                    if (HttpContext.User.Identity.IsAuthenticated)

//                    {
//                        int a = Int32.Parse(HttpContext.User.Identity.Name) ;
//                        User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
//                        eve.user = user;

//                        if (ctx.Verif(eve))
//                        {

//                            Cart cart = ctx.ListAllCarts().Where(r => r.Event.Id == eve.Id).FirstOrDefault();


//                            ctx.EditCart(eve, eve.Quantity,user);
//                        }

//                        else { ctx.AddToCart(eve, eve.Quantity,user); }


//                        return RedirectToAction("IndexEvent");
//                    }
//                    else
//                    {
//                        return View("Error");
//                    }
//                }
//            }
//            else
//            {
//                return View("Error");
//            }
//        }
//    }
//}
