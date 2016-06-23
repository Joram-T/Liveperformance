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
    public partial class FormNieuwHuurcontract : Form
    {
        Klassen.Verhuurbedrijf verhuurbedrijf = new Klassen.Verhuurbedrijf();
        Klassen.Database database;
        decimal prijs;

        public FormNieuwHuurcontract(Klassen.Database database)
        {
            InitializeComponent();
            this.database = database;
            dropdownvullen();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            try
            {
                prijsberekenen();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Selecteer een boot");
            }

            try
            {
                huurderencontractinvoegen(tbVoornaam.Text, tbAchternaam.Text, tbTussenvoegsel.Text, tbEmail.Text);
            }
            catch(Klassen.ongeldigemailexception OGE)
            {
                MessageBox.Show(OGE.Message);
            }

            //database.NieuwHuurcontract(database.Huurderid(tbVoornaam.Text, tbTussenvoegsel.Text, tbAchternaam.Text, tbEmail.Text), dtpBegin.Value, dtpEind.Value, );
        }

        private void btnMerenMogelijk_Click(object sender, EventArgs e)
        {
            try
            {
                lblMerenMogelijk.Text = "Aantal meren mogelijk: " + berekenmeren(nudBudget.Value).ToString();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Selecteer een boot");
            }           
        }

        private void btnActieradius_Click(object sender, EventArgs e)
        {
            if (database.GetBootType(database.Soortid(cmbBoot.SelectedItem.ToString())) == "MOTORBOOT")
            {
                verhuurbedrijf.BerekenActieradius(database.tankhinhoudSoort(database.Soortid(cmbBoot.SelectedItem.ToString())));
                lblAradius.Text = "";
                lblAradius.Text = "De actie radius is: " + verhuurbedrijf.BerekenActieradius(database.tankhinhoudSoort(database.Soortid(cmbBoot.SelectedItem.ToString()))).ToString();
            }
            else
            {
                lblAradius.Text = "";
                MessageBox.Show("Selecteer een motorboot");
            }
        }

        //Voert het huurcontract toe aan de database;
        public void huurderencontractinvoegen(string voornaam, string achternaam, string tussenvoegsel, string email)
        {
            if(!String.IsNullOrEmpty(voornaam) && !String.IsNullOrEmpty(achternaam) && !String.IsNullOrEmpty(email))
            {
                if (email.Contains("@"))
                {
                    if (database.Huurdercount(voornaam, tussenvoegsel, achternaam, email) <= 0)
                    {
                        database.NieuweHuurder(voornaam, tussenvoegsel, achternaam, email);
                        database.NieuwHuurcontract(database.Huurderid(voornaam, tussenvoegsel, achternaam, email), dtpBegin.Value, dtpEind.Value, prijs);
                        database.ArtikelHuurcontract(database.Artid("Zwemvest"), nudZwemvesten.Value);
                        database.ArtikelHuurcontract(database.Artid("Peddels"), nudPeddels.Value);
                        database.ArtikelHuurcontract(database.Artid("Dekzeil"), nudDekzeil.Value);
                        database.ArtikelHuurcontract(database.Artid("Tent"), nudTent.Value);
                        database.ArtikelHuurcontract(database.Artid("Kompas"), nudKompas.Value);
                        database.BootHuurcontract(database.MinBootID(database.Soortid(cmbBoot.SelectedItem.ToString())));
                        database.UpdateBoot(database.Soortid(cmbBoot.SelectedItem.ToString()));
                        MessageBox.Show("Huurcontract bevestigd");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        database.NieuwHuurcontract(database.Huurderid(voornaam, tussenvoegsel, achternaam, email), dtpBegin.Value, dtpEind.Value, prijs);
                        database.ArtikelHuurcontract(database.Artid("Zwemvest"), nudZwemvesten.Value);
                        database.ArtikelHuurcontract(database.Artid("Peddels"), nudPeddels.Value);
                        database.ArtikelHuurcontract(database.Artid("Dekzeil"), nudDekzeil.Value);
                        database.ArtikelHuurcontract(database.Artid("Tent"), nudTent.Value);
                        database.ArtikelHuurcontract(database.Artid("Kompas"), nudKompas.Value);
                        database.UpdateBoot(database.Soortid(cmbBoot.SelectedItem.ToString()));
                        MessageBox.Show("Huurcontract bevestigd");
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    throw new Klassen.ongeldigemailexception("Voer een geldig emailadres in.");
                }
            }
            else
            {
                MessageBox.Show("Vul alle gegevens in");
            }
           
           
        }

        //Berekent de totale prijs
        public void prijsberekenen()
        {
            decimal artikelenprijs = 0;
            decimal bootprijs = 0;
            decimal vaarprijs = 0;

            artikelenprijs = (nudZwemvesten.Value + nudPeddels.Value + nudDekzeil.Value + nudTent.Value + nudKompas.Value) * 1.25m;
            if (database.GetBootType(database.Soortid(cmbBoot.SelectedItem.ToString())) == "MOTORBOOT")
            {
                bootprijs = 15;
            }
            else
            {
                bootprijs = 10;
            }

            if (cbIjsselmeer.Checked)
            {
                vaarprijs += 2;
            }

            if (cbNoordzee.Checked)
            {
                vaarprijs += 2;
            }

            if(nudAantalmeren.Value < 5)
            {
                vaarprijs += nudAantalmeren.Value * 1;
            }

            else
            {
                vaarprijs += nudAantalmeren.Value * 1.5m;
            }

            prijs = artikelenprijs + bootprijs + vaarprijs;
            prijs *= Convert.ToDecimal(dtpEind.Value.Subtract(dtpBegin.Value).ToString("dd"));
        }

        // Vult de combobox met boten
        public void dropdownvullen()
        {
            foreach (string boot in database.BootSoorten())
            {
                cmbBoot.Items.Add(boot);
            }
        }

        // Berekent hoeveel meren er bevaren kunnen worden met het budget
        private int berekenmeren(decimal budget)
        {
            int aantalmeren = 0;
            decimal artikelenprijs = 0;
            decimal bootprijs = 0;
            decimal vaarprijs = 0;

            artikelenprijs = (nudZwemvesten.Value + nudPeddels.Value + nudDekzeil.Value + nudTent.Value + nudKompas.Value) * 1.25m;
            if (database.GetBootType(database.Soortid(cmbBoot.SelectedItem.ToString())) == "MOTORBOOT")
            {
                bootprijs = 15;
            }
            else
            {
                bootprijs = 10;
            }

            if (cbIjsselmeer.Checked)
            {
                vaarprijs += 2;
            }

            if (cbNoordzee.Checked)
            {
                vaarprijs += 2;
            }
            prijs = artikelenprijs + bootprijs + vaarprijs;
            prijs *= Convert.ToDecimal(dtpEind.Value.Subtract(dtpBegin.Value).ToString("dd"));

            budget -= prijs;

            if(budget > 7.5m)
            {
                while(budget >= 1.5m)
                {
                    aantalmeren++;
                    budget -= 1.5m;
                }
            }
            else
            {
                while(budget >= 1)
                {
                    aantalmeren++;
                    budget -= 1;
                }
            }

            if(aantalmeren > 12)
            {
                aantalmeren = 12;
            }
            return aantalmeren;

        }

    }
}
