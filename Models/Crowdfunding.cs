using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Crowdfunding
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Veuillez renseigner un titre pour votre campagne")]
        [MaxLength(20, ErrorMessage = "Le titre est trop long !")]
        public string NameCrowdfunding { get; set; }
        [Required(ErrorMessage = "Veuillez indiquez quand débute votre campagne")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Veuillez indiquez quand votre campagne se cloture")]
        public DateTime EndDate { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public Association AssociationCrowdfunding { get; set; }
        [Required(ErrorMessage = "Indiquez le montant que vous souhaitez obtenir")]
        public int AmountMax { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public int MinDonation { get; set; }
        public int MaxDonation { get; set; }

    }
}
