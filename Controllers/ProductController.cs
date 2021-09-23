using ProjetFostHer.Helpers;
using ProjetFostHer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartSession.Controllers
{
    public class ProductController : Controller
    {
 
        public IActionResult Index()
        {
            var ctx = new BddContext();

            return View(ctx.Products.ToList());
        }
    }
}
