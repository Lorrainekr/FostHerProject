using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Event
    {
  
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Champ obligatoire")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Veuillez indiquez quand débute votre evenement")]
        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Veuillez indiquez quand votre evenement se cloture")]
        public DateTime EndDate { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public Category Category { get; set; }
        //[Required(ErrorMessage = "Champ obligatoire")]
        public Artist ArtistEvent { get; set; }


    }
}
