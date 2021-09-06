using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class AdvancedUser
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
