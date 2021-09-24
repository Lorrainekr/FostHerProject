using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    namespace ProjetFostHer.Models
    {
        public class Cart
        {
            public int Id { get; set; }
        public double total { get; set; }
        public virtual List<Item> Items { get; set; }
        
    }
    }






