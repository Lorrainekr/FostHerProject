using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Product
    {
        public Product()
        {
        }


        //public Product(string name, double price, Event @event)
        //{
        //    Name = name;
        //    Price = price;
        //    Event = @event;
        //}

        //public Product(string name, double price, Crowdfunding crowdfunding)
        //{
        //    Name = name;
        //    Price = price;
        //    Crowdfunding = crowdfunding;
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Photo { get; set; }
        //public Event Event{ get; set; }
        //public Crowdfunding Crowdfunding { get; set; }
      
    }
}
