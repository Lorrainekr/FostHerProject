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
    }
}
