using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Account
    {
        public Account()
        {
        }

        public Account(double montant, int crowID)
        {
            Montant = montant;
            CrowID = crowID;
        }

        public int Id { get; set; }
        [Display(Name = "Carte bancaire")]
        public string NumeroCB { get; set; }
        [Display(Name = "Date d'expiration")]
        public string DateExpirationMois { get; set; }
       
        public string DateExpirationAnnee { get; set; }
        [Display(Name = "Code de vérification")]
        public string Crypto { get; set; }
        public double Solde { get; set; }
        public double Montant { get; set; }
        public int CrowID { get; set; }
        public int CartID { get; set; }
    }
}
