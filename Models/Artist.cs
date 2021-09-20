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
                           " Une longueur minimale de huit caractères")]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }
        [Display(Name = "Adresse")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [Display(Name = "Prénom")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [Display(Name = "Nom de famille")]
        public string LastName { get; set; }
        [Display(Name = "Nom de scène (facultatif)")]
        public string StageName { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [Display(Name = "Domaine artistique")]
        public Category Category { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        [StringLength(14, ErrorMessage = "Votre numéro de SIRET est composé de 14 chiffres")]
        public string Siret { get; set; }

        public Artist(string email, string password, string address, string firstName, string lastName, string stageName, Category category, string siret)
        {
            Email = email;
            Password = password;
            Address = address;
            FirstName = firstName;
            LastName = lastName;
            StageName = stageName;
            Category = category;
            Siret = siret;
        }

        public Artist()
        {
        }
    }
}
