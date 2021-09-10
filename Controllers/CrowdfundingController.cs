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
    }

}
