using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    class Vaarplaats
    {
        public int ID { get; }
        public string Naam { get; }
        public string Soort { get; }
        public Decimal Dagprijs { get; }

        public Vaarplaats(int id, string naam, string soort)
        {
            this.ID = id;
            this.Naam = naam;
            this.Soort = soort;

            if(soort.ToLower() == "anders")
            {
                Dagprijs = 2;
            }
            else
            {
                Dagprijs = 0.5m;
            }
        }
    }
}
