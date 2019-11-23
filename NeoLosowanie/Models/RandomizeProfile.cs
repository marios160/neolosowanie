using System;
using System.Collections.Generic;
using System.Text;

namespace NeoLosowanie.Models
{
    class RandomizeProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool SeparateMarriage { get; set; }
        public int NumberOfGroups { get; set; }
        public int FirstInGroup { get; set; } //0 - obojetnie, 1 - małżeństwa, 2 - samotni
        public bool MarriageAsOne { get; set; }



    }
}
