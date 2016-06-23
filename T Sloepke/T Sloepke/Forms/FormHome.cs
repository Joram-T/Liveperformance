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
    public partial class FormHome : Form
    {
        FormHuurcontracten huurcontracten;
        FormNieuwHuurcontract nieuwhuurcontract;
        Klassen.Database database = new Klassen.Database();

        public FormHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            huurcontracten = new FormHuurcontracten(database);
            huurcontracten.ShowDialog();
            if (huurcontracten.DialogResult == DialogResult.OK || huurcontracten.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            this.Hide();
            nieuwhuurcontract= new FormNieuwHuurcontract(database);
            nieuwhuurcontract.ShowDialog();
            if (nieuwhuurcontract.DialogResult == DialogResult.OK || nieuwhuurcontract.DialogResult == DialogResult.Cancel)
            {
                this.Show();
            }
        }
    }
}
