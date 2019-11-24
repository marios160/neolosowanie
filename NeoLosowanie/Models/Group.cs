using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    public class Group
    {
        public int Id { get; set; }
        public List<Person> PersonList { get; set; } 
    }
}
