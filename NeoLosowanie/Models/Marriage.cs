using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    class Marriage
    {
        public int Person1Id { get; set; }
        public int Person2Id { get; set; }

        public Marriage(int person1Id, int person2Id)
        {
            Person1Id = person1Id;
            Person2Id = person2Id;
        }
    }
}
