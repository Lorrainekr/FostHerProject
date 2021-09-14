using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class CartController : Controller
    {
        public IActionResult OrderNow()
        {
            using (IDal dal = new Dal())
            {

                List<Cart> cart = dal.ListAllCarts();
                if (!cart.Any())
                {
                    return View("Panier Vide");
                }
                else
                {
                    ViewBag.listcarts = cart;


                    return View();


                }

            }
        }
    }
}

