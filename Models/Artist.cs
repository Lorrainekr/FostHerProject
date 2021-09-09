using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Veuillez saisir une adresse mail valide")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
            ErrorMessage = "Votre mot de passe doit contenir au moins :" +
                           " Une lettre majuscule" +
                           " Une lettre minuscule" +
                           " Un chiffre" +
                           " Un caractère spécial" +
                           " Une longueur minimal de huit caractères")]
        public string Password { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string LastName { get; set; }
        public string StageName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Domain { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [StringLength(14, ErrorMessage = "Votre numéro de SIRET est composé de 14 chiffres")]
        public string Siret { get; set; }
    }
}
