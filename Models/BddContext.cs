﻿using ProjetFostHer.Models;
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

            Association asso1 = new Association("lokr@gmail.com", "Br12345,", "Lokri", "210 boulevard Pompidou 75011 Paris", "0652314598", "W456987123", "789456123");
            Association asso2 = new Association("lakr@gmail.com", "Br12346:", "Lowky", "22 rue Poupoupidou 75010 Somewhere", "0652314556", "W456987852", "789456258");
            Category cat1 = new Category();
            cat1.CategoryName = "Peinture";
            Category cat2 = new Category();
            cat1.CategoryName = "Cinema";
            Category cat3 = new Category();
            cat1.CategoryName = "Sculpture";




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
                   NameCrowdfunding = "Soutiens des artistes du 20eme",
                   StartDate = new DateTime(2021,09,10),
                   EndDate = new DateTime(2021,11,10),
                   AssociationCrowdfunding = asso1,
                   AmountMax = 30000,
                   MinDonation = 5,
                   MaxDonation = 1000,
                   Artist = new Artist(
                        "hdjbnd@gmail.com",
                        "Mn1d45$",
                        "80 rue",
                        "Jean",
                        "Dujardin",
                        "Jpm",
                        cat1,
                        "00551555"
                        )

               },

               new Crowdfunding
               {
                   NameCrowdfunding = "Soutiens des artistes du 10eme",
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
                        "Jean",
                        "Michael",
                        "JVG",
                        cat2,
                        "00551555"
                        )
               }
            );

            this.Events.AddRange(
               new Event
               {
                   Designation = "Soutiens des artistes du 20eme",
                   Type = "Conférence",
                   StartDate = new DateTime(2021, 09, 10),
                   EndDate = new DateTime(2021, 11, 10),
                   Stock = 500,
                   Price = 30,
                   Category = cat1,
                   lieu = "Bar l'Impromptu, Paris",
                   img = "~/img/visuel_crowdfunding.png",
                   product = new Product(),
                   ArtistEvent = new Artist(
                        "Mymen.jelassi2014@gmail.com",
                        "Mn12345$",
                        "9 rue",
                        "George",
                        "Michael",
                        "GM",
                        cat2,
                        "00551555"
                        )
               },

               new Event
               {
                   Designation = "Soutiens des artistes du 10eme",
                   Type = "Conférence",
                   StartDate = new DateTime(2021, 09, 10),
                   EndDate = new DateTime(2021, 11, 10),
                   Stock = 500,
                   Price = 40,
                   Category = cat1,
                   Lieu = "Bar l'Impromptu, Bobigny",
                   Img = "/Users/eleonorepean/GitHub/FostHerProject/wwwroot/img/visuel_crowdfunding.png",
                   product = new Product(),
                   ArtistEvent = new Artist(
                        "Mymen.jelassi2014@gmail.com",
                        "Mn12345$",
                        "9 rue",
                        "George",
                        "Michael",
                        "GM",
                        cat3,
                        "00551555"
                        )
               }
            ) ;

          

      this.SaveChanges();
        }
    }
}
