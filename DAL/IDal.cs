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
        List<User> ListAllUsers();
        List<Artist> ListAllArtists();
        void CreateUser(int id, string email, string password);
        void CreateArtist(string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret);
        void EditArtist(int id, string email, string password, string address, string firstname, string lastname, string stagename, string domain, string siret);
        void DeleteArtist(int id);
    }
}
