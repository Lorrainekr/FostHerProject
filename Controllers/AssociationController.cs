using Microsoft.AspNetCore.Mvc;
using ProjetFostHer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Controllers
{
    public class AssociationController : Controller
    {
        public IActionResult EditAssociation(int id)
        {
            if (id != 0)
            {
                using (IDal dal = new Dal())
            }
            return View();
        }
    }
}
