using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace T_Sloepke.Klassen
{
    public class Database
    {
        private OracleConnection con;
        private OracleCommand command;
        private OracleDataReader reader;

        public Database()
        {

            string constr = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))"
                          + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));"
                          + "User ID=DBI347664; PASSWORD=individueel;";

            con = new OracleConnection(constr);
        }


        public List<Huurcontract> Huurontracten()
        {
            List<Huurcontract> contracten = new List<Huurcontract>();
            List<Artikel> artikelen = new List<Artikel>();
            List<Vaarplaats> vaarplaatsen = new List<Vaarplaats>();
            List<Boot> boten = new List<Boot>();
            Huurder huurder = new Huurder(0, string.Empty, string.Empty, string.Empty, string.Empty);

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT * FROM HUURCONTRACT", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                command = new OracleCommand("SELECT * FROM HUURDER WHERE ID = '"+reader["HUURDERID"]+"' ", con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    huurder = new Huurder(Convert.ToInt32(reader["ID"]), reader["VOORNAAM"].ToString(), reader["TUSSENVOEGSEL"].ToString(), reader["ACHTERNAAM"].ToString(), reader["EMAILADRES"].ToString());
                }
                contracten.Add(new Huurcontract(Convert.ToInt32(reader["ID"]), Convert.ToDateTime(reader["DATUMVANAF"]), Convert.ToDateTime(reader["DATUMTOT"]), huurder, artikelen, vaarplaatsen, boten));
            }

            return contracten;
        }
    }
}
