using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    abstract class Boot
    {
        public int ID { get; }
        public string Naam { get; }
        public string Soort { get; }

        public Boot(int id, string naam, string soort)
        {
            this.ID = id;
            this.Naam = naam;
            this.Soort = soort;
        }
    }
}
