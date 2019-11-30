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
        public int CollectionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsMarriage { get; set; }
        public string Name { get { return LastName + " " + FirstName; }}

        public Person()
        {
        }
        public Person(int collectionId = 0)
        {
            this.CollectionId = collectionId;
        }

    }
}
