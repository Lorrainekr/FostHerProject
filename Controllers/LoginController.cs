using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjetFostHer.DAL;
using ProjetFostHer.Models;
using ProjetFostHer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
            HomeViewModel viewModel = new HomeViewModel { Authentification = HttpContext.User.Identity.IsAuthenticated};
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                viewModel.User = dal.GetUser(HttpContext.User.Identity.Name);
                return View(viewModel);
            }
            return View(viewModel); 
        }

        [HttpPost]
        public ActionResult IndexLogin(HomeViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                User user = dal.Authentification(viewModel.User.Email, viewModel.User.Password);
                if (user != null)
                {
                    var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, user.Id.ToString()),
                    };
                    var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");
                    var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                    HttpContext.SignInAsync(userPrincipal);

                    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);
                    return Redirect("/");
                }
                ModelState.AddModelError("User.Name", "Mail et/ou mot de passe incorrect(s)");
            }
            return View("ConfirmCreateAccount");
        }

        public IActionResult CreerCompte()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreerCompte(User user)
        {
            if (ModelState.IsValid)
            {
                int id = dal.AddUser(user.Name, user.Email, user.Password);

                var userClaims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, id.ToString()),
                        new Claim(ClaimTypes.Role, "Read")
                    };

                var ClaimIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { ClaimIdentity });
                HttpContext.SignInAsync(userPrincipal);

                return Redirect("/");
            }
            return View(user);
        }

        public ActionResult Deconnexion()
        {
            HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
