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

        private void VulLv()
        {
            foreach(Klassen.Huurcontract contract in database.Huurontracten())
            {
                ListViewItem item;
                item = item = new ListViewItem(Convert.ToString(contract.Huurder.Voornaam));
                item.SubItems.Add(contract.Huurder.Tussenvoegsel);
                item.SubItems.Add(contract.Huurder.Achternaam);
                item.SubItems.Add(contract.DatumVanaf.ToString());
                item.SubItems.Add(contract.DatumTot.ToString());
                lvHuurcontract.Items.Add(item);
            }
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
