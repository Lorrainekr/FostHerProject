using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.DAL
{
    public interface IDal : IDisposable
    {
        // Liste des classes
        List<User> ListAllUsers();
        List<Artist> ListAllArtists();
        List<Association> ListAllAssociations();
        List<Crowdfunding> ListAllCrowdfundings();
        List<Category> ListAllCategory();
        List<AdvancedUser> ListAllAdvancedUsers();

        List<Event> ListAllEvents();
        List<Cart> ListAllCarts();
        List<Account> ListAllAccounts();
        List<Item> ListAllItems();
        
        void BuyEvents(Cart cart);

        // Méthode pour les users
        void CreateUser(int id, string name, string email, string password);
        // log utilisateur :
        int AddUser(string name, string email, string password,Artist artist);
        int AddUser(string name, string email, string password, Admin admin);
        int AddUser(string name, string email, string password, AdvancedUser advancedUser);
        int AddUser(string name, string email, string password, Association association);
        int AddUserValidation(string name, string email, string password, Artist artist);
        void ValidateArtist(Artist artist);
        void RejectMembership(Artist art);
        void MembershipArtist(User user, string stagename, Category category, string siret, Association asso);
        User Authentification(string email, string password);
        User GetUser(int id);
        User GetUser(string idStr);
        void DeleteCreateDatabase();

        void AddItem(int CartId, Item item);
        void UpdateItemQuantity(int ItemId);
        void UpdateItemQuantity2(int ItemId, int q);
        void RemoveItem(int cartId, int itemId);

        // Méthode pour le panier
        //void AddToCart(Event eve,int quantity,User user);
        //void AddToCart(Crowdfunding cr, double d,User user);
        //void EditCart(Event eve,int q,User user);
        //void EditCart(Crowdfunding cr, double d,User user);
        //void EditQuantityCart(Event eve, int q, User u);
        //void EditCrowdfundingCart(Cart cart,Crowdfunding cr, double d, User u);
        //bool Verif(Event eve);

        //bool Verif(Crowdfunding cr);


        // Méthode pour les artistes
        void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret, Association asso);
        void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret);
        void DeleteArtist(int id);

        // Méthode pour les associations
        void CreateAssociation(string email, string password, string assoname, string address, string tel, string rna, string siren);
        void EditAssociation(int id, string email, string password, string assoname, string address, string tel, string rna, string siren);
        void DeleteAssociation(int id);

        // Méthode pour les crowdfundings
        void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, double amountmax, double mindonation, double maxdonation);
        void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, double amountmax, double mindonation, double maxdonation, Artist artist);
        void EditCrowdfunding(int id, string namecrowdfunding, DateTime startdate, DateTime enddate,  double amountmax, double mindonation, double maxdonation);
        
        void DeleteCrowdfunding(int id);
        void Contribute(Crowdfunding cr);

        // Méthode pour les évènements
        void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, double price, Category category, Artist artistevent);
        void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, double price, Category category, Association asso,Artist a);
        void EditEvent(int id, string designation, string type, DateTime startdate, DateTime enddate, double price);
        void DeleteEvent(int id);
        string EncodeMD5(string motDePasse);
    }
}
