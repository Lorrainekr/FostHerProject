using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.Models
{
    public class BddContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<AdvancedUser> AdvancedUsers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=FostHerUserList");
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Artists.AddRange(
                new Artist
                {
                    
                    Email="aymen17@hotmail.fr",
                    Password="12345",
                    Address="8 rue",
                    FirstName="Juan",
                    LastName="Mata",
                    StageName="JM",
                    Domain="Peinture",
                    Siret="00551515"
                   
                },
                new Artist
                {
                  
                    Email = "Mymen.jelassi2014@gmail.com",
                    Password = "12345",
                    Address = "9 rue",
                    FirstName = "George",
                    LastName = "Michael",
                    StageName = "GM",
                    Domain = "Musique",
                    Siret = "00551555"
                }
           
           

                 );

            this.SaveChanges();
        }
    }
}
