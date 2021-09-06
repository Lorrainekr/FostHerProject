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
        List<User> ListAllUsers();
        void CreateUser(int id, string email, string password);
    }
}
