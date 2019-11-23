using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person Spouse { get; set; }
        public int Level { get; set; }

    }
}
