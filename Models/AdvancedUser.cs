using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class AdvancedUser
    {
        public int Id { get; set; }
        
        public string Email { get; set; }
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        [Display(Name = "Adresse")]
        public string Address { get; set; }
        [Display(Name = "Téléphone")]
        public string Tel { get; set; }
        [Display(Name = "Nom")]
        public string FirstName { get; set; }
        [Display(Name = "Prénom")]
        public string LastName { get; set; }
    }
}
