using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    class User
    {
        [PrimaryKey,Unique]
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PasswordMD5 { get; set; }
    }
}
