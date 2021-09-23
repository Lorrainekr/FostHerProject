using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Helpers;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Payment(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Crowdfunding cr = dal.ListAllCrowdfundings().Where(r => r.Id == id).FirstOrDefault();
                    Account  account = new Account(cr.Donation,cr.Id);
                    if (cr == null)
                    {
                        return View("Error");
                    }
                    return View(account);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult Payment(Account acc)
        {
            if (!ModelState.IsValid)
                return View(acc);

            if (acc.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    foreach (Account a in ctx.ListAllAccounts())
                    {
                        if ((a.NumeroCB == acc.NumeroCB) && (a.Crypto == acc.Crypto) && (a.DateExpirationMois == acc.DateExpirationMois)&& (a.DateExpirationAnnee == acc.DateExpirationAnnee))
                        {
                            if (a.Solde > acc.Montant)
                            {
                                return View("Transcationapproved");
                                
                            }
                            
                        }
                    }
                    

                    Crowdfunding cr = ctx.ListAllCrowdfundings().Where(r => r.Id == acc.CrowID).FirstOrDefault();
                            ctx.CancelContribution(cr);
                            return View("Transactionfailed");
                        }
            }

                   
            else
            {
                return View("Error");
            }
        }

        public IActionResult PaymentEvent(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
                {
                    Cart cart = dal.ListAllCarts().Where(r => r.Id == id).FirstOrDefault();
                    Account account = new Account(cart.total, cart.Id);
                    if (cart == null)
                    {
                        return View("Error");
                    }
                    return View(account);
                }
            }
            return View("Error");
        }

        [HttpPost]
        public IActionResult PaymentEvent(Account acc)
        {
            if (!ModelState.IsValid)
                return View(acc);

            if (acc.Id != 0)
            {
                using (Dal ctx = new Dal())
                {
                    foreach (Account a in ctx.ListAllAccounts())
                    {
                        if ((a.NumeroCB == acc.NumeroCB) && (a.Crypto == acc.Crypto) && (a.DateExpirationMois == acc.DateExpirationMois) && (a.DateExpirationAnnee == acc.DateExpirationAnnee))
                        {
                            if (a.Solde > acc.Montant)
                            {
                                var cartId = SessionHelper.GetObjectFromJson<int>(HttpContext.Session, "cartId");
                                foreach (Item item in ctx.ListAllItems().ToList())
                                    {
                                    new Dal().RemoveItem(cartId, item.Id);
                                }
                                
                                
                                return View("Transcationapproved");

                            }

                        }
                    }


                    
                    return View("Transactionfailed");
                }
            }


            else
            {
                return View("Error");
            }
        }

    }
}
