﻿using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.DAL
{
    public interface IDal : IDisposable
    {
        void DeleteCreateDatabase();
        // Liste des classes
        List<User> ListAllUsers();
        List<Artist> ListAllArtists();
        List<Association> ListAllAssociations();
        List<Crowdfunding> ListAllCrowdfundings();
        List<Category> ListAllCategory();
        List<Event> ListAllEvents();
        List<Cart> ListAllCarts();
        void AddToCart(Event eve);
        // Méthode pour les users
        void CreateUser(int id, string email, string password);
        // Méthode pour les artistes
        void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret);
        void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret);
        void DeleteArtist(int id);
        // Méthode pour les associations
        void CreateAssociation(string email, string password, string assoname, string address, string tel, string rna, string siren);
        void EditAssociation(int id, string email, string password, string assoname, string address, string tel, string rna, string siren);
        void DeleteAssociation(int id);
        // Méthode pour les crowdfundings
        void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, int amountmax, int mindonation, int maxdonation);
        void EditCrowdfunding(int id, string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, int amountmax, int mindonation, int maxdonation);
        void DeleteCrowdfunding(int id);
        // Méthode pour les évènements
        void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, int stock, double price, Category category, Artist artistevent);
        void EditEvent(int id, string designation, string type, DateTime startdate, DateTime enddate, int stock, double price);
        void DeleteEvent(int id);

    }
}
