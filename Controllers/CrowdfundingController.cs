using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class CrowdfundingController : Controller
    {
        public IActionResult CrowdfundingIndex()
        {
            return View();
        }
        public IActionResult EditCrowdfunding(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding crowd = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                    if (crowd == null)
                    {
                        return View("Error");
                    }
                    return View(crowd);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult EditCrowdfunding(Crowdfunding crowd)
        {
            if (!ModelState.IsValid)
                return View(crowd);

            if (crowd.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.EditCrowdfunding
                        (
                        crowd.Id, 
                        crowd.NameCrowdfunding,
                        crowd.StartDate,
                        crowd.EndDate,
                        crowd.AssociationCrowdfunding,
                        crowd.AmountMax,
                        crowd.MinDonation,
                        crowd.MaxDonation
                         );

                    return RedirectToAction("Modification");
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult CreateCrowdfunding(Crowdfunding crowd)
        {

            if (!ModelState.IsValid)
                return View(crowd);
                using (Dal ctx = new Dal())
                {
                    ctx.CreateCrowdfunding
                        (
                        crowd.NameCrowdfunding,
                        crowd.StartDate,
                        crowd.EndDate,
                        crowd.AssociationCrowdfunding,
                        crowd.AmountMax,
                        crowd.MinDonation,
                        crowd.MaxDonation
                        );

                    return View("Modifications");
                }

        }

        public IActionResult DeleteCrowdfunding(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding crowd = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                    if (crowd == null)
                    {
                        return View("Error");
                    }
                    return View(crowd);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult DeleteCrowdfunding(Crowdfunding crowd)
        {
            if (!ModelState.IsValid)
                return View(crowd);

            if (crowd.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.DeleteCrowdfunding(crowd.Id);

                    return View("Modifications");
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult IndexCrowdfunding()
        {
            using (IDal dal = new Dal())
            {
                List<Crowdfunding> cr = dal.ListAllCrowdfundings();
                ViewBag.listcrowdfundings = cr;
            }
            return View();
        }


        public IActionResult CartCrowdfunding(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding cr = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();

                    if (cr == null)
                    {
                        return View("Error");
                    }
                    return View(cr);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult CartCrowdfunding(Crowdfunding cr)
        {

            if (!ModelState.IsValid)
                return View(cr);

            if (cr.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    if (ctx.Verif(cr))
                    {
                        Cart cart = ctx.ListAllCarts().Where(r => r.crowdfunding.Id == cr.Id).FirstOrDefault();
                        ctx.EditCart(cr, cr.Donation);
                    }

                    else { ctx.AddToCart(cr, cr.Donation); }


                    return RedirectToAction("IndexCrowdfunding");
                }
            }
            else
            {
                return View("Error");
            }
        }



    }

}
