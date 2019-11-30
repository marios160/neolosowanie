using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    class Collection
    {
        [PrimaryKey, Unique, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }

    }
}
