using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjetFostHer.Helpers;
using ProjetFostHer.Models;
using System;
using System.Collections;
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
            return _bddContext.Users.Include(c => c.advancedUser).Include(c => c.artist).Include(c => c.association).Include(c => c.admin).ToList();
        }

        public List<AdvancedUser> ListAllAdvancedUsers()
        {
            return _bddContext.AdvancedUsers.ToList();
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
        public List<Artist> ListAllArtists()
        {
            return _bddContext.Artists.Include(c => c.Category).Include(c => c.association).ToList();

        }
        public List<Event> ListAllEvents()
        {
            return _bddContext.Events.Include(c => c.Category).Include(c => c.user).Include(c => c.AssociationEvent).Include(c => c.ArtistEvent).Include(c => c.product).ToList();

        }

        public List<Cart> ListAllCarts()
        {

            
            return _bddContext.Carts.Include(c => c.Items).ToList();
        }

        public List<Account> ListAllAccounts()
        {

            
            return _bddContext.Accounts.ToList();
        }

        public List<Item> ListAllItems()
        {


            return _bddContext.Items.ToList();
        }

        public void AddItem(int CartId, Item item)
        {
            Cart cart = _bddContext.Carts.Find(CartId);
            cart.Items.Add(item);



            _bddContext.SaveChanges();
        }

        public void UpdateItemQuantity(int ItemId)
        {
            var item = _bddContext.Items.Find(ItemId);
            if (item != null)
            {
                item.Quantity += 1;
                _bddContext.SaveChanges();
            }
        }
        public void UpdateItemQuantity2(int ItemId,int q)
        {
            var item = _bddContext.Items.Find(ItemId);
            if (item != null)
            {
                item.Quantity += q;
                _bddContext.SaveChanges();
            }
        }

        public void RemoveItem(int cartId, int itemId)
        {
            Cart cart = GetCart(cartId);
            Item item = cart.Items.Where(it => it.Id == itemId).FirstOrDefault();

            cart.Items.Remove(item);

            _bddContext.SaveChanges();
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }
        public int CreateCart()
        {
            Cart cart = new Cart() { Items = new List<Item>() };
            _bddContext.Carts.Add(cart);
            _bddContext.SaveChanges();
            return cart.Id;
        }
        public Cart GetCart(int cartId)
        {

            return _bddContext.Carts.Include(c => c.Items).ThenInclude(it => it.Product).Where(c => c.Id == cartId).FirstOrDefault();
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

        public void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, Category category, string siret, Association asso)
        {
            User user = new User();

            Artist newArtist = new Artist()
            {
                Email = email,
                Password = password,
                Address = address,
                FirstName = firstname,
                LastName = lastname,
                StageName = stagename,
                Category = category,
                Siret = siret,
                association= asso
            };

            newArtist.Validation = "Valide";

            AddUser(newArtist.StageName, newArtist.Email, newArtist.Password, newArtist);

            _bddContext.SaveChanges();

        }

        public void MembershipArtist(User user, string stagename, Category category, string siret, Association asso)
        {


            Artist newArtist = new Artist()
            {
                Email = user.Email,
                Password = user.Password,
                Address = user.advancedUser.Address,
                FirstName = user.advancedUser.FirstName,
                LastName = user.advancedUser.LastName,
                Tel=user.advancedUser.Tel,
                StageName = stagename,
                Category = category,
                Siret = siret,
                association = asso
            };
            AdvancedUser ad = ListAllAdvancedUsers().Where(r => r.Id == user.advancedUser.Id).FirstOrDefault();
            

            _bddContext.AdvancedUsers.Remove(ad);
            _bddContext.Users.Remove(user);
            newArtist.Validation = "en attente";

            AddUserValidation(newArtist.LastName, newArtist.Email, newArtist.Password, newArtist);

            _bddContext.SaveChanges();

        }


        public void RejectMembership(Artist art)
        {


            AdvancedUser newAdvancedUser = new AdvancedUser()
            {
                
                Email = art.Email,
                Password = art.Password,
                Address = art.Address,
                FirstName = art.FirstName,
                LastName = art.LastName,
                Tel=art.Tel
               
            };
            Artist ar = ListAllArtists().Where(r => r.Id == art.Id).FirstOrDefault();


            _bddContext.Artists.Remove(ar);
            
            

            AddUser(newAdvancedUser.LastName, newAdvancedUser.Email, newAdvancedUser.Password, newAdvancedUser);

            _bddContext.SaveChanges();

        }



        public void ValidateArtist(Artist artist)
        {

            Artist art = _bddContext.Artists.Find(artist.Id);
            art.Validation = "Valide";

            _bddContext.Artists.Update(art);


            _bddContext.SaveChanges();

        }

        public void Contribute(Crowdfunding cr)
        {


            
            
            
            cr.SumCalculation();

            _bddContext.Crowdfundings.Update(cr);


            _bddContext.SaveChanges();

        }

        public void BuyEvents(Cart cart)
        {


            foreach (var item in cart.Items)
            {
                cart.total = cart.total + (item.Product.Price * item.Quantity);
            }
            //Cart crt = _bddContext.Carts.Find(cart.Id);
            //crt.total = cart.total;

            _bddContext.Carts.Update(cart);


            _bddContext.SaveChanges();

        }

        public void ClearafterTransaction(Cart cart)
        {
            

            


            _bddContext.SaveChanges();

        }


        public void CancelContribution(Crowdfunding cr)
        {
            cr.sum = cr.sum - cr.Donation;
            if (cr.sum < 0)
            {
                cr.sum = 0;
            }
            cr.Donation = 0;
            
            
            _bddContext.Crowdfundings.Update(cr);


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

            AddUser(newAssociation.AssoName, newAssociation.Email, newAssociation.Password, newAssociation);
            _bddContext.SaveChanges();
        }

        public void CreateCrowdfunding(string namecrowdfunding, DateTime startdate, DateTime enddate, Association associationcrowdfunding, double amountmax, double mindonation, double maxdonation,Artist artist)
        {

            Crowdfunding newCrowdfunding = new Crowdfunding()
            {
                NameCrowdfunding = namecrowdfunding,
                StartDate = startdate,
                EndDate = enddate,
                AssociationCrowdfunding = associationcrowdfunding,
                Artist=artist,
                AmountMax = amountmax,
                MinDonation = mindonation,
                MaxDonation = maxdonation
            };

            _bddContext.Crowdfundings.Add(newCrowdfunding);
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
        public void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, double price, Category category, Artist artistevent)
        {
            Product p = new Product();
            p.Name = designation;
            p.Price = price;
            Event newEvent = new Event()
            {
                Designation = designation,
                Type = type,
                StartDate = startdate,
                EndDate = enddate,
                
                Price = price,
                Category = category,
                ArtistEvent = artistevent,
                product=p
                
            };

            
            
            _bddContext.Events.Add(newEvent);
            _bddContext.Products.Add(p);
            _bddContext.SaveChanges();
        }

        public void CreateEvent(string designation, string type, DateTime startdate, DateTime enddate, double price, Category category, Association associationevent,Artist a)
        {
            Product p = new Product();
            p.Name = designation;
            p.Price = price;
            if ((a == null))
            {
                 a = new Artist();
            }
           

            Event newEvent = new Event()
            {
                Designation = designation,
                Type = type,
                StartDate = startdate,
                EndDate = enddate,
                ArtistEvent=a,
                Price = price,
                Category = category,
                AssociationEvent = associationevent,
                product=p
            };

            
            
            _bddContext.Events.Add(newEvent);
            _bddContext.Products.Add(p);
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

        public void EditCrowdfunding(int id, string namecrowdfunding, DateTime startdate, DateTime enddate,double amountmax, double mindonation, double maxdonation)
        {
            Crowdfunding crowd = _bddContext.Crowdfundings.Find(id);

            if (crowd != null)
            {
                crowd.NameCrowdfunding = namecrowdfunding;
                crowd.StartDate = startdate;
                crowd.EndDate = enddate;
                crowd.AmountMax = amountmax;
                crowd.MinDonation = mindonation;
                crowd.MaxDonation = maxdonation;
                _bddContext.SaveChanges();
            }
        }
        public void EditEvent(int id, string designation, string type, DateTime startdate, DateTime enddate, double price)
        {
            Event eve = _bddContext.Events.Find(id);

            if (eve != null)
            {
                eve.Designation = designation;
                eve.Type = type;
                eve.StartDate = startdate;
                eve.EndDate = enddate;
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

        //public void AddToCart(Event eve, int q,User a)
        //{
        //    Cart newCart = new Cart(eve);
        //    newCart.EventQuantity = q;
        //    newCart.user = a;


        //    _bddContext.Carts.Update(newCart);
        //    _bddContext.SaveChanges();
        //}

        //public void AddToCart(Crowdfunding cr, double d,User a)
        //{
        //    Cart newCart = new Cart(cr);
        //    newCart.CrowdfundingDonation = d;
        //    newCart.user = a;

        //    _bddContext.Carts.Update(newCart);
        //    _bddContext.SaveChanges();
        //}

        // Méthode login :
        public int AddUser(string name, string email, string password, Admin admin)
        {
            string motDePasse = EncodeMD5(password);
            User user = new User() { Name = name, Email = email, Password = motDePasse, admin = admin };
            _bddContext.Users.Add(user);
            _bddContext.SaveChanges();

            return user.Id;
        }

        public int AddUser(string name, string email, string password, Association association)
        {
            string motDePasse = EncodeMD5(password);
            User user = new User() { Name = name, Email = email, Password = motDePasse, association = association };
            _bddContext.Users.Add(user);
            _bddContext.SaveChanges();

            return user.Id;
        }

        public int AddUser(string name, string email, string password, Artist artist)
        {
            string motDePasse = EncodeMD5(password);
            User user = new User() { Name = name, Email = email, Password = motDePasse, artist = artist };
            _bddContext.Users.Add(user);
            _bddContext.SaveChanges();

            return user.Id;
        }
        public int AddUserValidation(string name, string email, string password, Artist artist)
        {
            
            User user = new User() { Name = name, Email = email, Password = password, artist = artist };
            _bddContext.Users.Add(user);
            _bddContext.SaveChanges();

            return user.Id;
        }



        public int AddUser(string name, string email, string password, AdvancedUser advancedUser)
        {
            string motDePasse = EncodeMD5(password);
            User user = new User() { Name = name, Email = email, Password = motDePasse, advancedUser = advancedUser };
            advancedUser.LastName = name;
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
        public string EncodeMD5(string motDePasse)
        {
            string motDePasseSel = "ChoixResto" + motDePasse + "ASP.NET MVC";
            return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.Default.GetBytes(motDePasseSel)));
        }
    }
}


//        public void EditCart(Event eve,int q,User u)
//        {
//            Cart cart = _bddContext.Carts.Find(eve.Id);
//            cart.EventQuantity += q;
//            cart.Event.Quantity+=q;
//            cart.user = u;

//            _bddContext.Carts.Update(cart);


               
//                _bddContext.SaveChanges();
            
//        }

//        public void EditCart(Crowdfunding cr, double d,User u)
//        {
//            Cart cart = _bddContext.Carts.Find(cr.Id);
//            cart.crowdfunding.Donation += d;
//            cart.CrowdfundingDonation += d;

//            _bddContext.Carts.Update(cart);



//            _bddContext.SaveChanges();

//        }

//        public void EditQuantityCart(Event eve, int q, User u)
//        {
//            Cart cart = ListAllCarts().Where(r => r.Event.Id == eve.Id).FirstOrDefault();
//            eve.Quantity = q;
//            cart.Event.Quantity = q;
//            cart.EventQuantity = q;
//            cart.user = u;

//            _bddContext.Events.Update(eve);
//            _bddContext.Carts.Update(cart);
           



//            _bddContext.SaveChanges();

//        }
       

//        public void EditCrowdfundingCart(Cart carte, Crowdfunding cr, double d, User u)
//        {
            
         

//            cr.Donation = d;
//            carte.CrowdfundingDonation = d;
//            carte.crowdfunding = cr;
//            carte.user = u;
//            _bddContext.Crowdfundings.Update(cr); 
//            //_bddContext.Carts.Update(carte);
            


//            _bddContext.SaveChanges();

//        }

       

//        public bool Verif(Event eve)

//        {
            
//            List<Cart> Li = _bddContext.Carts.Include(c => c.Event).ToList();
//            bool a = false;
//            foreach (Cart e in Li)
//            {
//                if (e.Event == null)
//                {
//                    a = false;
//                }
//                else if (e.Event.Designation.ToString().Equals(eve.Designation.ToString()) && !(string.IsNullOrEmpty(eve.Designation.ToString())))
//                {
//                    a = true;
//                    break;
//                }
//                else
//                {
//                    a = false;
//                }
//            }
//            return a;


//        }

//        public bool Verif(Crowdfunding cr)

//        {
//            bool a = false;
//            List<Cart> Li = _bddContext.Carts.Include(c => c.crowdfunding).Include(c => c.Event).ToList();
            
//            foreach (Cart e in Li)
//            {
//                if (e.crowdfunding == null)
//                {
//                    a=false;
//                }
//                else if (e.crowdfunding.NameCrowdfunding.ToString().Equals(cr.NameCrowdfunding.ToString()))
//                {
//                    a = true;
//                    break;
//                }
//                else
//                {
//                     a=false;
//                }

                   
//            }
//            return a;
            


//        }

//    }
//}

