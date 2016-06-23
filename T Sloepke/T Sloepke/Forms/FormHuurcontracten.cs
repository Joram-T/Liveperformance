using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Sloepke.Forms
{
    public partial class FormHuurcontracten : Form
    {
        Klassen.Database database;

        public FormHuurcontracten(Klassen.Database database)
        {
            this.database = database;
            InitializeComponent();
            Maaklvheader();
            VulLv();           
        }

        // Maakt headers aan bij de Listview
        private void Maaklvheader()
        {
            ColumnHeader header;

            header = new ColumnHeader();
            header.Text = "Voornaam";
            header.Width = lvHuurcontract.Width / 5;
            lvHuurcontract.Columns.Add(header);
            header = new ColumnHeader();
            header.Text = "Tussenvoegsel";
            header.Width = lvHuurcontract.Width / 5;
            lvHuurcontract.Columns.Add(header);
            header = new ColumnHeader();
            header.Text = "Achternaam";
            header.Width = lvHuurcontract.Width / 5;
            lvHuurcontract.Columns.Add(header);
            header = new ColumnHeader();
            header.Text = "Begin datum";
            header.Width = lvHuurcontract.Width / 5;
            lvHuurcontract.Columns.Add(header);
            header = new ColumnHeader();
            header.Text = "Eind datum";
            header.Width = lvHuurcontract.Width / 5 - 4;
            lvHuurcontract.Columns.Add(header);
            lvHuurcontract.View = View.Details;
        }

        // Vult de Listview met gegevens uit de database
        private void VulLv()
        {
            foreach(Klassen.Huurcontract contract in database.Huurontracten())
            {
                ListViewItem item;
                item = new ListViewItem(Convert.ToString(contract.Huurder.Voornaam));
                item.SubItems.Add(contract.Huurder.Tussenvoegsel);
                item.SubItems.Add(contract.Huurder.Achternaam);
                item.SubItems.Add(contract.DatumVanaf.ToString("dd-MM-yyyy"));
                item.SubItems.Add(contract.DatumTot.ToString("dd-MM-yyyy"));
                lvHuurcontract.Items.Add(item);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Huurcontracten.txt";
            save.Filter = "Text File | *.txt";

            save.ShowDialog();
                System.IO.StreamWriter writer = new System.IO.StreamWriter(save.OpenFile());
                foreach (Klassen.Huurcontract contract in database.Huurontracten())
                {
                    writer.WriteLine("Huurder voornaam: " + contract.Huurder.Voornaam);
                    writer.WriteLine("Huurder tussenvoegsel: " + contract.Huurder.Tussenvoegsel);
                    writer.WriteLine("Huurder achternaam: " + contract.Huurder.Achternaam);
                    writer.WriteLine("Begin datum: " + contract.DatumVanaf.ToString("dd-MM-yyyy"));
                    writer.WriteLine("Eind datum: " + contract.DatumTot.ToString("dd-MM-yyyy"));
                    writer.WriteLine(string.Empty);
                }
                writer.Dispose();
                writer.Close();
        }
    }
}
