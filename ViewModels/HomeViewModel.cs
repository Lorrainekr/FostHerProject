using Microsoft.AspNetCore.Http;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.ViewModels
{
    public class HomeViewModel
    {
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Association Associations { get; set; }
        public Artist Artists { get; set; }
        public Event Events { get; set; }
        public Cart Carts { get; set; }
        public Crowdfunding Crowdfundings { get; set; }
        public User User { get; set; }
        public bool Authentification { get; set; }

        public string ConfirmLoginName()
        {
            int a = Int32.Parse(HttpContext.User.Identity.Name);
           
            User user = ctx.ListAllUsers().Where(r => r.Id == a).FirstOrDefault();

        }

    }
}
