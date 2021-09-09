using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetFostHer.DAL
{
    public class Dal : IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public List<User> ListAllUsers()
        {
            return _bddContext.Users.ToList();
        }

        public List<Artist> ListAllArtists()
        {
            return _bddContext.Artists.ToList();
        }

        public List<Association> ListAllAssociations()
        {
            return _bddContext.Associations.ToList();
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public void CreateUser(int id, string email, string password)
        {
            User newUser = new User() { Id = id, Email = email, Password = password };
            _bddContext.Users.Add(newUser);
            _bddContext.SaveChanges();
        }

        public void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret)
        {

            Artist newArtist = new Artist() { Email = email, Password = password, Address = address, FirstName = firstname, LastName = lastname, StageName = stagename, Domain = domain, Siret = siret };

            _bddContext.Artists.Add(newArtist);
            _bddContext.SaveChanges();
        }

        public void CreateAssociation(string email, string password, string assoname, string address, string tel, string rna, string siren)
        {

            Association newAssociation = new Association() { Email = email, Password = password, AssoName = assoname, Address = address, Tel = tel, RNA = rna, Siren = siren };

            _bddContext.Associations.Add(newAssociation);
            _bddContext.SaveChanges();
        }


        public void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret)
        {
            Artist art = _bddContext.Artists.Find(id);

            if (art != null)
            {
                art.Email = email;
                art.Password = password;
                art.Address = address;
                art.FirstName = firstname;
                art.LastName = lastname;
                art.StageName = stagename;
                art.Domain = domain;
                art.Siret = siret;
                _bddContext.SaveChanges();
            }
        }

        public void EditAssociation(int id, string email, string password, string assoname, string address, string tel, string rna, string siren)
        {
            Association asso = _bddContext.Associations.Find(id);

            if (asso != null)
            {
                asso.Email = email;
                asso.Password = password;
                asso.AssoName = assoname;
                asso.Address = address;
                asso.Tel = tel;
                asso.RNA = rna;
                asso.Siren = siren;
            }
        }

        public void DeleteArtist(int id)
        {
            Artist art = _bddContext.Artists.Find(id);

            _bddContext.Artists.Remove(art);


            _bddContext.SaveChanges();

        }

        public void DeleteAssociation(int id)
        {
            Association asso = _bddContext.Associations.Find(id);

            _bddContext.Associations.Remove(asso);

            _bddContext.SaveChanges();
        }


    }
}

