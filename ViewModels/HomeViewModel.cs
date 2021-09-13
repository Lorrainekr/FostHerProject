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
    }
}
