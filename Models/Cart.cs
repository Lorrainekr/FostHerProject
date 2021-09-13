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

        public Cart(Event @event)
        {
            this.Event = @event;
            
        }

        public int Id { get; set; }
        
        public  Event Event { get; set; }
   
       
   

      
      



    }
}
