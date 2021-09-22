using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;



namespace ProjetFostHer.Controllers
{
    public class CrowdfundingController : Controller

    {

        public IActionResult CreateCrowdfunding(Crowdfunding cr)

        {
            using (Dal ctx = new Dal())
            {
                if (HttpContext.User.Identity.Name == null) { return View("Error"); }
                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
               if (user.artist == null && user.association == null)
                {
                    return View("Error");
               }
            }
           
           if (!ModelState.IsValid)
                return View(cr);
           
            using (Dal ctx = new Dal())
            {

                int a = Int32.Parse(HttpContext.User.Identity.Name);
                User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                if (!(user.artist == null) && (user.artist.Validation == "Valide"))
                {
                    
                    Artist artist = ctx.ListAllArtists().Where(r => r.Id == user.artist.Id).FirstOrDefault();
                    ctx.CreateCrowdfunding(cr.NameCrowdfunding,cr.StartDate,cr.EndDate,artist.association,cr.AmountMax,cr.MinDonation,cr.MaxDonation,artist);

                    return View("Modifications");
                }
                else if (!(user.association == null))
                {
                    Association asso = ctx.ListAllAssociations().Where(r => r.Id == user.association.Id).FirstOrDefault();
                    ctx.CreateCrowdfunding(cr.NameCrowdfunding, cr.StartDate, cr.EndDate, asso, cr.AmountMax, cr.MinDonation, cr.MaxDonation);

                }


                else
                {
                    return View("Error");
                }

            }

            return View("Modifications");
        }


        public IActionResult IndexCrowdfunding()
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
                    else if (!(user.artist == null) || !(user.association == null))
                    {
                        ViewBag.user = "A";
                    }
                    else
                    {
                        ViewBag.user = "B";
                    }
                }
                List<Crowdfunding> crwd = dal.ListAllCrowdfundings();

                ViewBag.listCrowdfundings = crwd;
                
            }
            return View();
        }

        public IActionResult PageCrowdfunding(int id)
        {
            using (IDal dal = new Dal())
            {
                
                Crowdfunding crwd = dal.ListAllCrowdfundings().Where(a => a.Id == id).FirstOrDefault();
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
                    else if (!(crwd.AssociationCrowdfunding == null))
                    {
                        if (!(user.association == null))
                        {
                            if ((crwd.AssociationCrowdfunding.Id == user.association.Id))
                            {
                                ViewBag.user = "A";
                            }
                        }
                    }
                    else if (!(crwd.ArtistCrowdfunding == null))
                    {
                        if (!(user.artist == null))
                        {
                            if (crwd.ArtistCrowdfunding.Id == user.artist.Id)
                            {
                                ViewBag.user = "A";
                            }
                        }
                        

                        else
                        {
                            ViewBag.user = "B";
                        }

                    }
                }
                return View(crwd);
            }
        }

        public IActionResult Contribute(int id)

        {
            using (IDal dal = new Dal())
            {

                Crowdfunding cr = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                
                return View(cr);
            }

        }

        [HttpPost]
        public IActionResult Contribute(Crowdfunding cr)

        {
            using (IDal dal = new Dal())
            {

                dal.Contribute(cr);

            }
            return RedirectToAction( "Payment", "Payment",new { id = cr.Id });
        }

        public IActionResult EditCrowdfunding(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding crw = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                    if (crw == null)
                    {
                        return View("Error");
                    }
                    return View(crw);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult EditCrowdfunding(Crowdfunding crw)
        {
            if (!ModelState.IsValid)
                return View(crw);

            if (crw.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.EditCrowdfunding(crw.Id, crw.NameCrowdfunding, crw.StartDate, crw.EndDate, crw.AmountMax, crw.MinDonation, crw.MaxDonation);

                    return View("Modifications");
                }
            }
            else
            {
                return View("Error");
            }
        }


        public IActionResult DeleteCrowdfunding(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding crw = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                    if (crw == null)
                    {
                        return View("Error");
                    }
                    return View(crw);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult DeleteEvent(Crowdfunding crw)
        {
            if (!ModelState.IsValid)
                return View(crw);

            if (crw.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.DeleteEvent(crw.Id);

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



























//    {
//        public IActionResult EditCrowdfunding(int id)
//        {
//            if (id != 0)
//            {
//                using (IDal dal = new Dal())
//                {
//                    Crowdfunding crowd = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
//                    if (crowd == null)
//                    {
//                        return View("Error");
//                    }
//                    return View(crowd);
//                }
//            }
//            return View("Error");
//        }

//        [HttpPost]
//        public IActionResult EditCrowdfunding(Crowdfunding crowd)
//        {
//            if (!ModelState.IsValid)
//                return View(crowd);

//            if (crowd.Id != 0)
//            {
//                using (Dal ctx = new Dal())
//                {
//                    ctx.EditCrowdfunding
//                        (
//                        crowd.Id,
//                        crowd.NameCrowdfunding,
//                        crowd.StartDate,
//                        crowd.EndDate,
//                        crowd.AssociationCrowdfunding,
//                        crowd.AmountMax,
//                        crowd.MinDonation,
//                        crowd.MaxDonation
//                         );

//                    return RedirectToAction("Modification");
//                }
//            }
//            else
//            {
//                return View("Error");
//            }
//        }

//        public IActionResult CreateCrowdfunding(Crowdfunding crowd)
//        {

//            if (!ModelState.IsValid)
//                return View(crowd);
//            using (Dal ctx = new Dal())
//            {
//                ctx.CreateCrowdfunding
//                    (
//                    crowd.NameCrowdfunding,
//                    crowd.StartDate,
//                    crowd.EndDate,
//                    crowd.AssociationCrowdfunding,
//                    crowd.AmountMax,
//                    crowd.MinDonation,
//                    crowd.MaxDonation
//                    );

//                return View("Modifications");
//            }

//        }

//        public IActionResult DeleteCrowdfunding(int id)
//        {
//            if (id != 0)
//            {
//                using (IDal dal = new Dal())
//                {
//                    Crowdfunding crowd = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
//                    if (crowd == null)
//                    {
//                        return View("Error");
//                    }
//                    return View(crowd);
//                }
//            }
//            return View("Error");
//        }

//        [HttpPost]
//        public IActionResult DeleteCrowdfunding(Crowdfunding crowd)
//        {
//            if (!ModelState.IsValid)
//                return View(crowd);

//            if (crowd.Id != 0)
//            {
//                using (Dal ctx = new Dal())
//                {
//                    ctx.DeleteCrowdfunding(crowd.Id);

//                    return View("Modifications");
//                }
//            }
//            else
//            {
//                return View("Error");
//            }
//        }

//        public IActionResult IndexCrowdfunding()
//        {
//            using (IDal dal = new Dal())
//            {
//                List<Crowdfunding> cr = dal.ListAllCrowdfundings();
//                ViewBag.listcrowdfundings = cr;
//                int a = Int32.Parse(HttpContext.User.Identity.Name);
//                User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
//                ViewBag.listcrowdfundings = cr;
//                ViewData["id"] = user.Id;
//            }
//            return View();
//        }


//        public IActionResult CartCrowdfunding(int id)
//        {
//            if (id != 0)
//            {
//                using (IDal dal = new Dal())
//                {
//                    Crowdfunding cr = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
//                    if (HttpContext.User.Identity.IsAuthenticated)
                        
//                    {
//                        int a = Int32.Parse(HttpContext.User.Identity.Name);
//                        User user = dal.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
                       
//                        cr.user = user;

//                        if (cr == null)
//                        {
//                            return View("Error");
//                        }
//                        return View(cr);
//                    }
//                }
//            }
//            return View("Error");
//        }

//        [HttpPost]
//        public IActionResult CartCrowdfunding(Crowdfunding cr)
//        {

//            if (!ModelState.IsValid)
//                return View(cr);

//            if (cr.Id != 0)
//            {
//                using (Dal ctx = new Dal())
//                {
//                    if (HttpContext.User.Identity.IsAuthenticated)

//                    {
//                        int a = Int32.Parse(HttpContext.User.Identity.Name);
//                        User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
//                        cr.user = user;
//                        if (ctx.Verif(cr))
//                        {
//                            Cart cart = ctx.ListAllCarts().Where(r => r.crowdfunding.Id == cr.Id).FirstOrDefault();
//                            ctx.EditCart(cr, cr.Donation, user);
//                        }
//                        else { ctx.AddToCart(cr, cr.Donation, user); }


//                        return RedirectToAction("IndexCrowdfunding");


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

