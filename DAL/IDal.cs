using ProjetFostHer.Models;
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
        // Méthode pour le user
        void CreateUser(int id, string email, string password);
        // Méthode pour l'artiste
        void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret);
        void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret);
        void DeleteArtist(int id);
        // Méthode pour l'association
        void CreateAssociation(string email, string password, string assoname, string address, string tel, string rna, string siren);
        void EditAssociation(int id, string email, string password, string assoname, string address, string tel, string rna, string siren);
        void DeleteAssociation(int id);
        // Méthode pour le crowdfunding
        void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, int amountmax, int mindonation, int maxdonation);
        void EditCrowdfunding(int id, string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, int amountmax, int mindonation, int maxdonation);
        void DeleteCrowdfunding(int id);
    }
}
