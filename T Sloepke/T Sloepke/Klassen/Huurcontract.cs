using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    class Huurcontract
    {
        public int ID { get; }
        public DateTime DatumVanaf { get; }
        public DateTime DatumTot { get; }
        public Huurder Huurder { get; }
        public List<Artikel> Artikelen { get; }
        public List<Vaarplaats> Vaarplaatsen { get; }
        public List<Boot> Boten { get; }

        public Huurcontract(int id, DateTime datumvanaf, DateTime datumtot, Huurder huurder, List<Artikel> artikelen, List<Vaarplaats> vaarplaatsen, List<Boot> boten)
        {
            this.ID = id;
            this.DatumVanaf = datumvanaf;
            this.DatumTot = datumtot;
            this.Huurder = huurder;
            this.Artikelen = artikelen;
            this.Vaarplaatsen = vaarplaatsen;
            this.Boten = boten;
        }

        public void ExportHuurcontract(int id, DateTime datumvanaf, DateTime datumtot, Huurder huurder, List<Artikel> artikelen, List<Vaarplaats> vaarplaatsen, List<Boot> boten)
        {

        }
    }
}
