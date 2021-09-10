using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Association
    {
        public Association()
        {
        }

        public Association(string email, string password, string assoName, string address, string tel, string rNA, string siren)
        {
            Email = email;
            Password = password;
            AssoName = assoName;
            Address = address;
            Tel = tel;
            RNA = rNA;
            Siren = siren;
        }


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
        [Required(ErrorMessage = "Champ obligatoire")]
        public string AssoName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Address { get; set; }
        public string Tel { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [StringLength(10, ErrorMessage = "Votre numéro de RNA est composé de une lettre et de 9 chiffres")]
        public string RNA { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [StringLength(9 , ErrorMessage = "Votre numéro de SIREN est composé de 9 chiffres") ]

        public string Siren { get; set; }
    }
}
