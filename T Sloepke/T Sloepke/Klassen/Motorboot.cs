using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    class Motorboot : Boot
    {
        public int TankInhoud { get; }

        public Motorboot(int id, string naam, string soort, int inhoud) : base(id, naam, soort)
        {
            this.TankInhoud = inhoud;
        }

        public int BerekenActieradius()
        {
            int actieradius;

            actieradius = this.TankInhoud * 15;

            return actieradius;
        }
    }
}
