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
        [MaxLength(50, ErrorMessage = "Le titre est trop long !")]
        public string NameCrowdfunding { get; set; }
        [Required(ErrorMessage = "Veuillez indiquez quand débute votre campagne")]
        public DateTime StartDate { get; set; }
        //[Required(ErrorMessage = "Veuillez indiquez quand termine votre campagne")]
        public DateTime EndDate { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public Category Category { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public Association AssociationCrowdfunding { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public Artist ArtistCrowdfunding { get; set; }
        [Required(ErrorMessage = "Indiquez le montant que vous souhaitez obtenir")]
        public double AmountMax { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public double MinDonation { get; set; }
        public double MaxDonation { get; set; }
        public double Donation { get; set; }
        public double sum { get; set; }
        public Artist Artist { get; set; }
        public User user { get; set; }
        public int Contrib { get; set; }


        public void SumCalculation()
        {

            sum = sum + Donation;
            Contrib = Contrib + 1;
            
        }
        
    }
}
