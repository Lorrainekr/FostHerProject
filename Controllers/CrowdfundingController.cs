using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class CrowdfundingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
