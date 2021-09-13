using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Cart
    {
        public Cart()
        {
        }

        public Cart(Event @event, int quantity)
        {
            this.Event = @event;
            this.Quantity = quantity;
        }

        public int Id { get; set; }
        
        public  Event Event { get; set; }
        public int Quantity { get; set; }
   

      
      



    }
}
