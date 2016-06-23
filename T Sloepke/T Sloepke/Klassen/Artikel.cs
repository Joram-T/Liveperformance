using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    public class Artikel
    {
        public int ID { get; }
        public string Naam { get; }
        public decimal Dagprijs { get; }

        public Artikel(int id, string naam)
        {
            this.ID = id;
            this.Naam = naam;
            this.Dagprijs = 1.25m;
        }

    }
}
