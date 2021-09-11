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
            return View();
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

        public IActionResult CreateArtist(Artist art)
        {

            if (!ModelState.IsValid)
                return View(art);
            using (Dal ctx = new Dal())
                { 
                ctx.CreateArtist(art.Email, art.Password, art.Address, art.FirstName, art.LastName, art.StageName, art.Category, art.Siret);

                return View("Modifications");
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
