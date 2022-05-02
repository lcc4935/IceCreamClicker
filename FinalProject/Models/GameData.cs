using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Models
{
    public class GameData
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Info { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
