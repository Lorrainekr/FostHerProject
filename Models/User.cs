using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class User
    {
        [Display(Name = "Prénom")]
        public string Name { get; set; }
        //[Required]
        public string Email { get; set; }
        //[Required]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        public int Id { get; set; }

        public Admin admin { get; set; }
        
        public Association association { get; set; }

        public Artist artist { get; set; }

        public AdvancedUser advancedUser { get; set; }
    }
}
