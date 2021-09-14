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

        public Cart(Crowdfunding crowdfunding)
        {
            this.crowdfunding = crowdfunding;
        }

        public int Id { get; set; }
        
        public  Event Event { get; set; }

        public Crowdfunding crowdfunding { get; set; }

        public User user { get; set; }








    }
}
