using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class AssociationController : Controller
    {
        public IActionResult IndexAssociation()
        {
            return View();
        }
        public IActionResult EditAssociation(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Association asso = dal.ListAllAssociations().Where(r => r.Id == id).FirstOrDefault();
                    if (asso == null)
                    {
                        return View("Error");
                    }
                    return View(asso);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult EditAssociation(Association asso)
        {
            if (!ModelState.IsValid)
                return View(asso);

            if(asso.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.EditAssociation
                        (
                        asso.Id, 
                        asso.Email, 
                        asso.Password, 
                        asso.AssoName, 
                        asso.Address, 
                        asso.Tel, 
                        asso.RNA, 
                        asso.Siren
                        );

                    return RedirectToAction("Modification");
                }
            }
            else
            {
                return View("Error");
            }
        }

        public IActionResult CreateAssociation()
        {

            
                Association asso = new Association();
                return View(asso);
            
          

        }
        [HttpPost]
        public IActionResult CreateAssociation(Association asso)
        {

            if (!ModelState.IsValid)
                return View(asso);
            using (Dal ctx = new Dal())
            {
  
                    ctx.CreateAssociation(asso.Email,asso.Password,asso.AssoName,asso.Address,asso.Tel,asso.RNA,asso.Siren);

                    return View("Creation");
              
            }

        }

        public IActionResult DeleteAssociation(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Association asso = dal.ListAllAssociations().Where(r => r.Id == id).FirstOrDefault();
                    if (asso == null)
                    {
                        return View("Error");
                    }
                    return View(asso);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult DeleteAssociation(Association asso)
        {
            if (!ModelState.IsValid)
                return View(asso);

            if (asso.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    ctx.DeleteAssociation(asso.Id);

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
