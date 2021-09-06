using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.Models;
using ProjetFostHer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Association associationPicasso = new Association 
            { 
                Address = "Paris 20 eme", 
                Tel = "22222222",
                RNA = "11111111",
                Siren = "hldpssjggfg4647879889C"
            };

            HomeViewModel homeviewmodel = new HomeViewModel
            {
                Message = "Bienvenue à l'association Picasso !",
                Date = DateTime.Now,
                Associations = associationPicasso
            };

            return View(associationPicasso);
        }
    }
}
