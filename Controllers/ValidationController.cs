using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult IndexValidation()
        
        {
                      using (IDal dal = new Dal())
                        {
                            
                            int a = Int32.Parse(HttpContext.User.Identity.Name);
                            
                            User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                            List<Artist> artist = dal.ListAllArtists().Where(r => r.association == user.association).ToList();
                            ViewBag.listArtists = artist;
                            ViewData["id"] = user.Id;
                        }
                        return View();
        }

        public IActionResult Validation(int id)

        {
            using (IDal dal = new Dal())
            {

                int a = Int32.Parse(HttpContext.User.Identity.Name);

                User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                Artist artist = dal.ListAllArtists().Where(r => r.Id == id).FirstOrDefault();
                dal.ValidateArtist(artist);
                return View(artist);
            }
            
        }

        [HttpPost]
        public IActionResult Validation(Artist artist)

        {
            using (IDal dal = new Dal())
            {

                int a = Int32.Parse(HttpContext.User.Identity.Name);

                User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();

                if (artist.Validation == "Valide")
                {
                    dal.ValidateArtist(artist);
                }
                if (artist.Validation == "Refus")
                {
                    dal.RejectMembership (artist);
                }

            }
            return RedirectToAction("IndexValidation");
        }


        
        public IActionResult MembershipValidation()
        {

            
            using (Dal ctx = new Dal())
           {

                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
              
                Artist art = new Artist();

               
              



               return View(art);

           }

        }

      [HttpPost]
        public IActionResult MembershipValidation(Artist art)
        {
         

            using (Dal ctx = new Dal())
            {

                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                Association assos = ctx.ListAllAssociations().Where(r => r.AssoName == art.association.AssoName).FirstOrDefault();



                ctx.MembershipArtist(user, art.StageName, art.Category, art.Siret, assos);

                    return View("FormulaireAdhésion");
                
            }

        }







    }
}








