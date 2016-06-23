using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_Sloepke.Klassen
{
    class ongeldigemailexception : Exception
    {
        public ongeldigemailexception(string message) : base(message)
        {
        }
    }
}
