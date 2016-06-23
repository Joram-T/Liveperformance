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

        #region ID's
        public List<int> HuurcontractenID()
        {
            List<int> ids = new List<int>();
            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT ID FROM HUURCONTRACT", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ids.Add(Convert.ToInt32(reader["ID"]));
            }
            con.Close();
            return ids;
        }

        public int MaxHuurcontractID()
        {
            int id = 0;
            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT MAX(ID) FROM HUURCONTRACT", con);
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["MAX(ID)"]);
            }
            con.Close();
            return id;
        }

        public int MinBootID(int soortid)
        {
            int id = 0;
            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT Min(ID) FROM BOOT WHERE BEZET = 'N' AND SOORTID =:soortid", con);
            command.Parameters.Add(new OracleParameter("soortid", OracleDbType.Int32)).Value = soortid;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["MIN(ID)"]);
            }
            con.Close();
            return id;
        }

        public int Soortid(string soort)
        {
            int id = 0;

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT ID FROM SOORT WHERE NAAM =:soort", con);
            command.Parameters.Add(new OracleParameter("soort", OracleDbType.Varchar2)).Value = soort;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
            }
            con.Close();
            return id;
        }

        public int Artid(string artikel)
        {
            int id = 0;

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT ID FROM ARTIKEL WHERE NAAM =:artikel", con);
            command.Parameters.Add(new OracleParameter("artikel", OracleDbType.Varchar2)).Value = artikel;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
            }
            con.Close();
            return id;
        }

        public int Huurderid(string voornaam, string tussenvoegsel, string achternaam, string email)
        {
            int id = 0;
            try { con.Open(); } catch { };
            if (!String.IsNullOrEmpty(tussenvoegsel))
            {
                command = new OracleCommand("SELECT ID FROM HUURDER WHERE VOORNAAM =:voornaam AND TUSSENVOEGSEL =:tussenvoegsel AND ACHTERNAAM =:achternaam AND EMAILADRES =:email", con);
                command.Parameters.Add(new OracleParameter("voornaam", OracleDbType.Varchar2)).Value = voornaam;
                command.Parameters.Add(new OracleParameter("tussenvoegsel", OracleDbType.Varchar2)).Value = tussenvoegsel;
                command.Parameters.Add(new OracleParameter("achternaam", OracleDbType.Varchar2)).Value = achternaam;
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = email;
            }
            else
            {
                command = new OracleCommand("SELECT ID FROM HUURDER WHERE VOORNAAM =:voornaam AND TUSSENVOEGSEL IS NULL AND ACHTERNAAM =:achternaam AND EMAILADRES =:email", con);
                command.Parameters.Add(new OracleParameter("voornaam", OracleDbType.Varchar2)).Value = voornaam;
                command.Parameters.Add(new OracleParameter("achternaam", OracleDbType.Varchar2)).Value = achternaam;
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = email;
            }       

            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID"]);
            }
            con.Close();
            return id;
        }

        public int MaxHuurderid()
        {
            int id = 0;
            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT MAX(ID) FROM HUURDER", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["MAX(ID)"]);
            }
            con.Close();
            return id;
        }
        #endregion

        #region Inserts

        public void NieuweHuurder(string voornaam, string tussenvoegsel, string achternaam, string email)
        {
            int id = MaxHuurderid() + 1;

            try { con.Open(); } catch { };
            command = new OracleCommand("INSERT INTO HUURDER VALUES(:id, :voornaam, :tussenvoegsel, :achternaam, :email)", con);
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;
            command.Parameters.Add(new OracleParameter("voornaam", OracleDbType.Varchar2)).Value = voornaam;
            command.Parameters.Add(new OracleParameter("tussenvoegsel", OracleDbType.Varchar2)).Value = tussenvoegsel;
            command.Parameters.Add(new OracleParameter("achternaam", OracleDbType.Varchar2)).Value = achternaam; 
            command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = email;

            command.ExecuteNonQuery();

            command = new OracleCommand("commit", con);
            command.ExecuteNonQuery();

            con.Close();
        }

        public void NieuwHuurcontract(int huurderid, DateTime begindatum, DateTime einddatum, Decimal prijs)
        {
            int id = MaxHuurcontractID() + 1;
            try { con.Open(); } catch { };
            command = new OracleCommand("INSERT INTO HUURCONTRACT VALUES(:id, :huurderid, TO_DATE(:begin, 'dd-mon-yyyy hh:mi:ss PM'), TO_DATE(:end, 'DD-MON-YYY'), :prijs)", con);
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;
            command.Parameters.Add(new OracleParameter("huurderid", OracleDbType.Int32)).Value = huurderid;
            command.Parameters.Add(new OracleParameter("begin", OracleDbType.Varchar2)).Value = begindatum;
            command.Parameters.Add(new OracleParameter("end", OracleDbType.Date)).Value = einddatum;
            command.Parameters.Add(new OracleParameter("prijs", OracleDbType.Int32)).Value = prijs;

            command.ExecuteNonQuery();
            con.Close();
        }

        public void ArtikelHuurcontract(int artid, decimal aantal)
        {
            int id = MaxHuurcontractID();
            try { con.Open(); } catch { };
            command = new OracleCommand("INSERT INTO HUURCONTRACT_ARTIKEL VALUES(:id, :artid, :aantal)", con);
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;
            command.Parameters.Add(new OracleParameter("artid", OracleDbType.Int32)).Value = artid;
            command.Parameters.Add(new OracleParameter("aantal", OracleDbType.Varchar2)).Value = aantal;

            command.ExecuteNonQuery();
            con.Close();
        }

        public void BootHuurcontract(int bootid)
        {
            int id = MaxHuurcontractID();
            try { con.Open(); } catch { };
            command = new OracleCommand("INSERT INTO HUURCONTRACT_BOOT VALUES(:id, :bootid)", con);
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;
            command.Parameters.Add(new OracleParameter("bootid", OracleDbType.Int32)).Value = bootid;
            command.ExecuteNonQuery();
            con.Close();
        }

        #endregion


        public void UpdateBoot(int bootid)
        {
            try { con.Open(); } catch { };
            command = new OracleCommand("UPDATE BOOT SET BEZET ='Y' WHERE ID =:bootid", con);
            command.Parameters.Add(new OracleParameter("int bootid", OracleDbType.Char)).Value = bootid;
            command.ExecuteNonQuery();
            con.Close();
        }

        public int Huurdercount(string voornaam, string tussenvoegsel, string achternaam, string email)
        {
            int count = 0;

            try { con.Open(); } catch { };

            if (String.IsNullOrEmpty(tussenvoegsel))
            {
                command = new OracleCommand("SELECT COUNT(*) FROM HUURDER WHERE VOORNAAM =:voornaam AND TUSSENVOEGSEL IS NULL AND ACHTERNAAM =:achternaam AND EMAILADRES =:email", con);
                command.Parameters.Add(new OracleParameter("voornaam", OracleDbType.Varchar2)).Value = voornaam;
                command.Parameters.Add(new OracleParameter("achternaam", OracleDbType.Varchar2)).Value = achternaam;
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = email;
            }
            else
            {
                command = new OracleCommand("SELECT COUNT(*) FROM HUURDER WHERE VOORNAAM =:voornaam AND TUSSENVOEGSEL =:tussenvoegsel AND ACHTERNAAM =:achternaam AND EMAILADRES =:email", con);
                command.Parameters.Add(new OracleParameter("voornaam", OracleDbType.Varchar2)).Value = voornaam;
                command.Parameters.Add(new OracleParameter("tussenvoegsel", OracleDbType.Varchar2)).Value = tussenvoegsel;
                command.Parameters.Add(new OracleParameter("achternaam", OracleDbType.Varchar2)).Value = achternaam;
                command.Parameters.Add(new OracleParameter("email", OracleDbType.Varchar2)).Value = email;
            }
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                count = Convert.ToInt32(reader["COUNT(*)"]);
            }
            con.Close();
            return count;
        }

        public List<Huurcontract> Huurontracten()
        {
            List<Huurcontract> contracten = new List<Huurcontract>();
            List<Artikel> artikelen = new List<Artikel>();
            List<Vaarplaats> vaarplaatsen = new List<Vaarplaats>();
            List<Boot> boten = new List<Boot>();
            Huurder huurder = new Huurder(0, string.Empty, string.Empty, string.Empty, string.Empty);
            DateTime begin = DateTime.Now;
            DateTime end = DateTime.Now;
            int id = 0;
            
            foreach(int i in HuurcontractenID())
            {
                huurder = getHuurder(i);

                try { con.Open(); } catch { };
                command = new OracleCommand("SELECT * FROM HUURCONTRACT WHERE ID =:id", con);
                command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = i;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    begin = Convert.ToDateTime(reader["DATUMVANAF"]);
                    end = Convert.ToDateTime(reader["DATUMTOT"]);
                    contracten.Add(new Huurcontract(id, begin, end, huurder, artikelen, vaarplaatsen, boten));
                }
            }
            con.Close();           
            return contracten;
        }

        public Huurder getHuurder(int id)
        {
            Huurder huurder = new Huurder(0, string.Empty, string.Empty, string.Empty, string.Empty);
            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT * FROM HUURDER WHERE ID =:id ", con);
            command.Parameters.Add(new OracleParameter("id", OracleDbType.Int32)).Value = id;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                huurder = new Huurder(Convert.ToInt32(reader["ID"]), reader["VOORNAAM"].ToString(), reader["TUSSENVOEGSEL"].ToString(), reader["ACHTERNAAM"].ToString(), reader["EMAILADRES"].ToString());
            }
            con.Close();
            return huurder;
        }

        public int tankhinhoudSoort(int soortid)
        {
            int inhoud = 0;

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT TANKINHOUD FROM SOORT WHERE ID =:soortid", con);
            command.Parameters.Add(new OracleParameter("soortid", OracleDbType.Varchar2)).Value = soortid;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                inhoud = Convert.ToInt32(reader["TANKINHOUD"]);
            }
            con.Close();
            return inhoud;
        }

        public string GetBootType(int soortid)
        {
            string type = string.Empty;

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT DISTINCT(TYPEBOOT) FROM BOOT WHERE SOORTID =:soortid", con);
            command.Parameters.Add(new OracleParameter("soortid", OracleDbType.Int32)).Value = soortid;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                type = reader["TYPEBOOT"].ToString();
            }
            con.Close();
            return type;
         }

        public List<string> BootSoorten()
        {
            List<string> soorten = new List<string>();

            try { con.Open(); } catch { };
            command = new OracleCommand("SELECT NAAM FROM SOORT", con);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                soorten.Add(reader["NAAM"].ToString());
            }

            con.Close();
            return soorten;
        } 


    }
}
