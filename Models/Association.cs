﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class Association
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string RNA { get; set; }
        public string Siren { get; set; }
    }
}
