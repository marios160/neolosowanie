using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    public class Person
    {
        [PrimaryKey,Unique, AutoIncrement]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SupouseId { get; set; }
        [Ignore]
        public Person Spouse { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Person(int clientId = 0)
        {
            this.ClientId = clientId;
        }

    }
}
