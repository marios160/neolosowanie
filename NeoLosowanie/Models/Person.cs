﻿using System;
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
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
}
