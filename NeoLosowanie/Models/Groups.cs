using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    public class Groups
    {
        public List<Group> GroupsList { get; set; }

        public Groups()
        {

        }
        public override string ToString()
        {
            return "GRUPY";
        }
    }
}
