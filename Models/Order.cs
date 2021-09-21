using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Event Event { get; set; }

        public Crowdfunding crowdfunding { get; set; }
        public Cart Carts { get; set; }
        
        //public double calcul()
        //{
        //    double S = 0;
        //    S = S + Carts.crowdfunding.Donation + (Carts.Event.Price + Carts.Event.Quantity);
        //    return S;
        //}
    }
}
