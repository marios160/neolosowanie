using NeoLosowanie.Repositories;
using NeoLosowanie.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    public class User
    {
        [PrimaryKey,Unique]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordMD5 { get; set; }
        public bool IsLogged { get; set; }

        public User(string email, string password)
        {
            this.Email = email.Trim();
            this.PasswordMD5 = SystemService.MD5Hash(password);
        }
        public User()
        {

        }

        public void Login()
        {
            this.IsLogged = true;
            UserRepository.LogInOut(this);
        }

        internal void Logout()
        {
            this.IsLogged = false;
            UserRepository.LogInOut(this);
        }
    }
}
