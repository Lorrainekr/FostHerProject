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
                    Password="Pn12345!",
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
                    Password = "Mn12345$",
                    Address = "9 rue",
                    FirstName = "George",
                    LastName = "Michael",
                    StageName = "GM",
                    Domain = "Musique",
                    Siret = "00551555"
                }
            );
            this.Associations.AddRange(
               new Association
               {

                   Email = "lokr@gmail.com",
                   Password = "Br12345,",
                   AssoName = "Lokri",
                   Address = "210 boulevard Pompidou 75011 Paris",
                   Tel = "0652314598",
                   RNA = "W456987123",
                   Siren = "789456123"
               },
               new Association
               {

                   Email = "lakr@gmail.com",
                   Password = "Br12346:",
                   AssoName = "Lowky",
                   Address = "22 rue Poupoupidou 75010 Somewhere",
                   Tel = "0652314556",
                   RNA = "W456987852",
                   Siren = "789456258"
               }
            );

            this.SaveChanges();
        }
    }
}
