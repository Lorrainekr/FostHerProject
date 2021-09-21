using ProjetFostHer.Models;
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
        public DbSet<Crowdfunding> Crowdfundings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=rrrrr;database=FostHerUserList");
        }
        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();

            Association asso1 = new Association("femmesdelombre@gmail.com", "512398!uu!", "Sortir les femmes de l'ombre", "23, rue de l'écuyer, Noisy Le Roi 93130", "0123236789", "H763820717", "786543097");
            Association asso2 = new Association("femmesdelombre@gmail.com", "512376du!!!", "Femmes artistes ici et là-bas", "11, rue du Maréchal Foch, Argens 11200", "0123276789", "K763845717", "986541097");
            Association asso3 = new Association("aware.asso@gmail.com", "7863!76du", "AWARE", "45, rue des maraichers, Paris 75020", "0156785623", "L749267396", "234908758");
            Association asso4 = new Association("fabriquedanse@gmail.com", "!6753!76du", "La Fabrique de la Danse", "78, rue des petits prés, Nantes 44000", "0156785623", "L749267396", "234908758");
            Association asso5 = new Association("astrea@gmail.com", "!7589!76du", "Astrea", "67, rue de la grande truanderie, Paris 75002", "0176458790", "R563789653", "764908637");
            Category cat1 = new Category(); cat1.CategoryName = "Peinture";
            Category cat2 = new Category(); cat2.CategoryName = "Cinema";
            Category cat3 = new Category(); cat3.CategoryName = "Sculpture";
            Category cat4 = new Category(); cat4.CategoryName = "Street Art";
            Category cat5 = new Category(); cat5.CategoryName = "Musique";
            Category cat6 = new Category(); cat6.CategoryName = "Danse";

            this.Accounts.AddRange(
                new Account
                {
                    Id=1,
                    NumeroCB="5134148609019174",
                    DateExpirationMois="03",
                    DateExpirationAnnee="2023",
                    Crypto="283",
                    Solde=20000
                       
                },
                new Account
                {
                    Id=2,
                    NumeroCB = "513518000000001",
                    DateExpirationMois = "12",
                    DateExpirationAnnee = "2025",
                    Crypto = "123",
                    Solde = 0
                }

                );
            this.SaveChanges();
                

            this.Products.AddRange(
                new Product
                {
                    Id = 1,
                    Name = "product1",
                    Price = 111.0
                },
                new Product
                {
                    Id = 2,
                    Name = "product2",
                    Price = 222.0
                },
                new Product
                {
                    Id = 3,
                    Name = "product3",
                    Price = 333.0
                },
                new Product
                {
                    Id = 4,
                    Name = "product4",
                    Price = 444.0
                }
            );

            this.SaveChanges();

            Product a = new Product();
            a.Price = 80;
            a.Name = "Tap Jam avec Lior Krief et Prabhu Edouard";

            this.Users.AddRange(
                new User
                    {
                        Name = "Low",
                        Email = "lock@gmail.com",
                        Password = "FB-32-9E-B0-0E-A1-D6-76-5D-D1-3B-8E-C0-26-3C-CB",
                       
                        
                    },

                new User
                    {
                        Name = "Tom",
                        Email = "tom@gmail.com",
                        Password = "FB-32-9E-B0-0E-A1-D6-76-5D-D1-3B-8E-C0-26-3C-CB"
                    }
                    );


            this.Artists.AddRange(
                new Artist
                {
                    
                    Email="aymen17@hotmail.fr",
                    Password="Pn12345!",
                    Address="8 rue",
                    FirstName="Juan",
                    LastName="Mata",
                    StageName="JM",
                    association=asso3,
                    Category= cat1,
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
                    association = asso2,
                    Category = cat2,
                    Siret = "00551555"
                }
            );
            //this.Associations.AddRange(
            //   new Association
            //   {

            //       Email = "lokr@gmail.com",
            //       Password = "Br12345,",
            //       AssoName = "Lokri",
            //       Address = "210 boulevard Pompidou 75011 Paris",
            //       Tel = "0652314598",
            //       RNA = "W456987123",
            //       Siren = "789456123"
            //   },
            //   new Association
            //   {

            //       Email = "lakr@gmail.com",
            //       Password = "Br12346:",
            //       AssoName = "Lowky",
            //       Address = "22 rue Poupoupidou 75010 Somewhere",
            //       Tel = "0652314556",
            //       RNA = "W456987852",
            //       Siren = "789456258"
            //   }
            //);

            this.Crowdfundings.AddRange(
               new Crowdfunding 
               {
                   NameCrowdfunding = "J'ai 3 Amours: Piano, Contrebasse, Claquettes !",
                   StartDate = new DateTime(2021,09,10),
                   EndDate = new DateTime(2021,11,10),
                   AssociationCrowdfunding = asso1,
                   AmountMax = 45000,
                   MinDonation = 5,
                   MaxDonation = 1000,
                   Artist = new Artist(
                        "roxbutterfly@gmail.com",
                        "Pn12345!",
                        "80 rue de la mer",
                        "Roxanne",
                        "Butterfly",
                        "Roxanne Butterfly",
                        cat1,
                        asso4,
                        "00551555"
                        )
               },

               new Crowdfunding
               {
                   NameCrowdfunding = "Soutenez la création des artistEs du 10eme",
                   StartDate = new DateTime(2021,09,10),
                   EndDate = new DateTime(2021, 11, 10),
                   AssociationCrowdfunding = asso2,
                   AmountMax = 30000,
                   MinDonation = 5,
                   MaxDonation = 1000,
                   Artist = new Artist(
                        "hdjbnd@gmail.com",
                        "Mn12345$",
                        "9 rue",
                        "Séverine",
                        "Michel",
                        "Séverine Michel",
                        cat2,
                        asso5,
                        "00551575"
                        )
               }
            );
            
            this.Events.AddRange(
               new Event
               {
                   Designation = a.Name,
                   Type = "Spectacle",
                   StartDate = new DateTime(2021, 02, 10),
                   EndDate = new DateTime(2021, 03, 11),
                   AssociationEvent = asso2,
                   Stock = 400,
                   Price = 800,
                   Category = cat1,
                   Lieu = "Bar l'Impromptu, Paris",
                   Img = "~/img/visuel_crowdfunding.png",
                   product = a,
                   ArtistEvent = new Artist(
                        "roxbutterfly@gmail.com",
                        "Pn12345!",
                        "80 rue de la mer",
                        "Roxanne",
                        "Butterfly",
                        "Roxanne Butterfly",
                        cat1,
                        asso1,
                        "00551555"
                        )
               },

               new Event
               {
                   Designation = "Les femmes dans la peinture abstraite",
                   Type = "Conférence",
                   StartDate = new DateTime(2021, 09, 10),
                   EndDate = new DateTime(2021, 08, 10),
                   Stock = 40,
                   Price = 800,
                   Category = cat3,
                   Lieu = "La Mutinerie, Paris",
                   Img = "/Users/eleonorepean/GitHub/FostHerProject/wwwroot/img/visuel_crowdfunding.png",
                   product = new Product(),
                   ArtistEvent = new Artist(
                        "sylvettemarchal@gmail.com",
                        "Mn12345$",
                        "18 rue des alouettes",
                        "Sylvette",
                        "Marchal",
                        "Sylvette Marchal",
                        cat1,
                        asso4,
                        "00551559"
                        )
               },

               new Event
               {
                   Designation = "Piano Sonata No. 3 (Chopin)",
                   Type = "Spectacle",
                   StartDate = new DateTime(2021, 10, 22),
                   EndDate = new DateTime(2021, 10, 29),
                   Stock = 150,
                   Price = 10,
                   Category = cat5,
                   Lieu = "Conservatoire de Boulogne-Billancourt",
                   Img = "/Users/eleonorepean/GitHub/FostHerProject/wwwroot/img/visuel_crowdfunding.png",
                   product = new Product(),
                   ArtistEvent = new Artist(
                        "sylvettemarchal@gmail.com",
                        "Mn12F345$",
                        "18 rue des grands ruisseaux",
                        "Amélie",
                        "Joly",
                        "Amélie Joly",
                        cat5,
                        asso3,
                        "00551659"
                        )
               }
            );

          

      this.SaveChanges();
        }
    }
}
