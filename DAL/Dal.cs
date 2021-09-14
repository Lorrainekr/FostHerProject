using Microsoft.EntityFrameworkCore;
using ProjetFostHer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            return _bddContext.Artists.Include(c => c.Category).ToList();
        }

        public List<Association> ListAllAssociations()
        {
            return _bddContext.Associations.ToList();
        }

        public List<Crowdfunding> ListAllCrowdfundings()
        {
            return _bddContext.Crowdfundings.Include(c => c.AssociationCrowdfunding).Include(c => c.Artist).ToList();
        }
        public List<Category> ListAllCategory()
        {
            return _bddContext.Categories.ToList();
        }
        public List<Event> ListAllEvents()
        {
           return _bddContext.Events.Include(c => c.ArtistEvent).Include(c => c.Category).ToList();
          
        }

        public List<Cart> ListAllCarts()
        {

            return _bddContext.Carts.Include(c => c.Event).Include(c => c.crowdfunding).ToList();
        }


        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public void CreateUser(int id, string name, string email, string password)
        {
            User newUser = new User() 
            { 
                Id = id,
                Name = name,
                Email = email, 
                Password = password
            };

            _bddContext.Users.Add(newUser);
            _bddContext.SaveChanges();
        }

        public void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret)
        {

            Artist newArtist = new Artist()
            {
                Email = email,
                Password = password,
                Address = address,
                FirstName = firstname,
                LastName = lastname,
                StageName = stagename,
                Category = category,
                Siret = siret
            };

            _bddContext.Artists.Add(newArtist);
            _bddContext.SaveChanges();
        }

        public void CreateAssociation(string email, string password, string assoname, string address, string tel, string rna, string siren)
        {

            Association newAssociation = new Association()
            {
                Email = email,
                Password = password,
                AssoName = assoname,
                Address = address,
                Tel = tel,
                RNA = rna,
                Siren = siren
            };

            _bddContext.Associations.Add(newAssociation);
            _bddContext.SaveChanges();
        }

        public void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, double amountmax, double mindonation, double maxdonation)
        {
            Crowdfunding newCrowdfunding = new Crowdfunding()
            {
                NameCrowdfunding = namecrowdfunding,
                StartDate = startdate,
                EndDate = enddate,
                AssociationCrowdfunding = associationcrowdfunding,
                AmountMax = amountmax,
                MinDonation = mindonation,
                MaxDonation = maxdonation
            };

            _bddContext.Crowdfundings.Add(newCrowdfunding);
            _bddContext.SaveChanges();
        }
        public void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, int stock, double price, Category category, Artist artistevent)
        {
            Event newEvent = new Event()
            {
                Designation = designation,
                Type = type,
                StartDate = startdate,
                EndDate = enddate,
                Stock = stock,
                Price = price,
                Category = category,
                ArtistEvent = artistevent
            };

            _bddContext.Events.Add(newEvent);
            _bddContext.SaveChanges();
        }
        public void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret)
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
                art.Category = category;
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
                _bddContext.SaveChanges();
            }
        }

        public void EditCrowdfunding(int id, string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, double amountmax, double mindonation, double maxdonation)
        {
            Crowdfunding crowd = _bddContext.Crowdfundings.Find(id);

            if (crowd != null)
            {
                crowd.NameCrowdfunding = namecrowdfunding;
                crowd.StartDate = startdate;
                crowd.EndDate = enddate;
                crowd.AssociationCrowdfunding = associationcrowdfunding;
                crowd.AmountMax = amountmax;
                crowd.MinDonation = mindonation;
                crowd.MaxDonation = maxdonation;
                _bddContext.SaveChanges();
            }
        }
        public void EditEvent(int id, string designation, string type, DateTime startdate, DateTime enddate, int stock, double price)
        {
            Event eve = _bddContext.Events.Find(id);

            if (eve != null)
            {
                eve.Designation = designation;
                eve.Type = type;
                eve.StartDate = startdate;
                eve.EndDate = enddate;
                eve.Stock = stock;
                eve.Price = price;

                _bddContext.SaveChanges();
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

        public void DeleteCrowdfunding(int id)
        {
            Crowdfunding crowd = _bddContext.Crowdfundings.Find(id);

            _bddContext.Crowdfundings.Remove(crowd);

            _bddContext.SaveChanges();
        }
        public void DeleteEvent(int id)
        {
            Event eve = _bddContext.Events.Find(id);

            _bddContext.Events.Remove(eve);

            _bddContext.SaveChanges();
        }

        public void AddToCart(Event eve, int q)
        {
            Cart newCart = new Cart(eve);
            newCart.Event.Quantity = q;
            

            _bddContext.Carts.Update(newCart);
            _bddContext.SaveChanges();
        }

        public void AddToCart(Crowdfunding cr, double d)
        {
            Cart newCart = new Cart(cr);
            newCart.crowdfunding.Donation = d;
            

            _bddContext.Carts.Update(newCart);
            _bddContext.SaveChanges();
        }

        // Méthode login :
        public int AddUser(string name, string email, string password)
        {
            string motDePasse = EncodeMD5(password);
            User user = new User() { Name = name, Email = email, Password = motDePasse };
            _bddContext.Users.Add(user);
            _bddContext.SaveChanges();

            return user.Id;
        }

        public User Authentification(string email, string password)
        {
            string motDePasse = EncodeMD5(password);
            User user = _bddContext.Users.FirstOrDefault(u => u.Email == email && u.Password == motDePasse);
            return user;
        }

        public User GetUser(int id)
        {
            return _bddContext.Users.Find(id);
        }

        public User GetUser(string idStr)
        {
            int id;
            if (int.TryParse(idStr, out id))
            {
                return this.GetUser(id);
            }
            return null;
        }
        private string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "ChoixResto" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }


        public void EditCart(Event eve,int q)
        {
            Cart cart = _bddContext.Carts.Find(eve.Id);
            cart.Event.Quantity+=q;

            _bddContext.Carts.Update(cart);


               
                _bddContext.SaveChanges();
            
        }

        public void EditCart(Crowdfunding cr, double d)
        {
            Cart cart = _bddContext.Carts.Find(cr.Id);
            cart.crowdfunding.Donation += d;

            _bddContext.Carts.Update(cart);



            _bddContext.SaveChanges();

        }


        public bool Verif(Event eve)

        {
            
            List<Cart> Li = _bddContext.Carts.Include(c => c.Event).ToList();
            bool a = false;
            foreach (Cart e in Li)
            {
                if (e.Event == null)
                {
                    a = false;
                }
                else if (e.Event.Designation.ToString().Equals(eve.Designation.ToString()) && !(string.IsNullOrEmpty(eve.Designation.ToString())))
                {
                    a = true;
                    break;
                }
                else
                {
                    a = false;
                }
            }
            return a;


        }

        public bool Verif(Crowdfunding cr)

        {
            bool a = false;
            List<Cart> Li = _bddContext.Carts.Include(c => c.crowdfunding).Include(c => c.Event).ToList();
            
            foreach (Cart e in Li)
            {
                if (e.crowdfunding == null)
                {
                    a=false;
                }
                else if (e.crowdfunding.NameCrowdfunding.ToString().Equals(cr.NameCrowdfunding.ToString()))
                {
                    a = true;
                    break;
                }
                else
                {
                     a=false;
                }

                   
            }
            return a;
            


        }

    }
}

