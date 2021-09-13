using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using ProjetFostHer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class LoginController : Controller
    {
        private IDal dal;
        public LoginController()
        {
            dal = new Dal();
        }
        public IActionResult IndexLogin()
        {
            UserViewModel viewModel = new UserViewModel { Authentification = HttpContext.User.Identity.IsAuthenticated};
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                viewModel.User = dal.GetUser(HttpContext.User.Identity.Name);
                return View(viewModel);
            }
            return View(viewModel); 
        }

        public IActionResult CreerCompte()
        {
            return View();
        }
    }
}
