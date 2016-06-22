using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    class Huurder
    {
        public int ID { get; }
        public string Voornaam { get; }
        public string Tussenvoegsel { get; }
        public string Achternaam { get; }
        public string Email { get; }

        public Huurder(int id, string voornaam, string tussenvoegsel, string achternaam, string email)
        {
            this.ID = id;
            this.Voornaam = voornaam;
            this.Tussenvoegsel = tussenvoegsel;
            this.Achternaam = achternaam;
            this.Email = email;
        }
    }
}
