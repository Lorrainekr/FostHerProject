using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
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
            
                using (Dal ctx = new Dal())
                {
                
                if (!(HttpContext.User.Identity.Name == null))
                {
                 int  a = Int32.Parse(HttpContext.User.Identity.Name);
 
                    User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();
              
                ViewData["Message"] = user.Name.ToString();
                }

            }

            
            return View();
        }
    }
}
