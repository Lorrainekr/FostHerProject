using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class ArtistController : Controller
    {
        public IActionResult IndexArtist()
        {
            using (IDal dal = new Dal())
            {
                if (!(HttpContext.User.Identity.IsAuthenticated))
                {
                    ViewBag.user = "B";
                }
                else
                {
                    int a = Int32.Parse(HttpContext.User.Identity.Name);

                    User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                    if (user == null)
                    {
                        ViewBag.user = "B";
                    }
                    else if (!(user.association == null))
                    {
                        ViewBag.user = "A";
                    }
                    else
                    {
                        ViewBag.user = "B";
                    }
                }
                List<Artist> art = dal.ListAllArtists();

                ViewBag.listArtists = art;

            }
            return View();
        }

        public IActionResult PageArtist(int id)
        {
            using (IDal dal = new Dal())
            {
                Artist art = dal.ListAllArtists().Where(a => a.Id == id).FirstOrDefault();
                return View(art);
            }
        }

        public IActionResult EditArtist(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Artist art = dal.ListAllArtists().Where(r => r.Id == id).FirstOrDefault();
                    if (art == null)
                    {
                        return View("Error");
                    }
                    return View(art);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult EditArtist(Artist art)
        {
            if (!ModelState.IsValid)
                return View(art);

            if (art.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.EditArtist(art.Id, art.Email, art.Password, art.Address, art.FirstName, art.LastName, art.StageName, art.Category, art.Siret);
                    
                    return RedirectToAction("Modifications");
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult CreateArtist()
        {

            Artist art = new Artist();
                return View(art);
           
        }
        [HttpPost]
        public IActionResult CreateArtist(Artist art)
        {

            if (!ModelState.IsValid)
                return View(art);
            using (Dal ctx = new Dal())
                {
                
                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                if (!(user.association == null))
                {
                    Association asso = ctx.ListAllAssociations().Where(r => r.Id == user.association.Id).FirstOrDefault();
                    ctx.CreateArtist(art.Email, art.Password, art.Address, art.FirstName, art.LastName, art.StageName, art.Category, art.Siret, asso);
                    return View("Modifications");
                    
                }else return View("Error");
            }
            
        }

        public IActionResult DeleteArtist(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Artist art = dal.ListAllArtists().Where(r => r.Id == id).FirstOrDefault();
                    if (art == null)
                    {
                        return View("Error");
                    }
                    return View(art);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult DeleteArtist(Artist art)
        {
            if (!ModelState.IsValid)
                return View(art);

            if (art.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.DeleteArtist(art.Id);

                    return View("Modifications");
                }
            }
            else
            {
                return View("Error");
            }
        }





    }
}
