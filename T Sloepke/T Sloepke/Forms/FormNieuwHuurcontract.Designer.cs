namespace T_Sloepke.Forms
{
    partial class FormNieuwHuurcontract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpGegevens = new System.Windows.Forms.GroupBox();
            this.lblEinddatum = new System.Windows.Forms.Label();
            this.lblBegindatum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblTussenvoegsel = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEind = new System.Windows.Forms.DateTimePicker();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.tbTussenvoegsel = new System.Windows.Forms.TextBox();
            this.gbVaarplaatsen = new System.Windows.Forms.GroupBox();
            this.nudAantalmeren = new System.Windows.Forms.NumericUpDown();
            this.cbNoordzee = new System.Windows.Forms.CheckBox();
            this.cbIjsselmeer = new System.Windows.Forms.CheckBox();
            this.lblAantalmeren = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMerenMogelijk = new System.Windows.Forms.Button();
            this.lblMerenMogelijk = new System.Windows.Forms.Label();
            this.nudBudget = new System.Windows.Forms.NumericUpDown();
            this.lblBudget = new System.Windows.Forms.Label();
            this.gbBoot = new System.Windows.Forms.GroupBox();
            this.lblAradius = new System.Windows.Forms.Label();
            this.btnActieradius = new System.Windows.Forms.Button();
            this.lblBoot = new System.Windows.Forms.Label();
            this.cmbBoot = new System.Windows.Forms.ComboBox();
            this.gbArtikelen = new System.Windows.Forms.GroupBox();
            this.nudKompas = new System.Windows.Forms.NumericUpDown();
            this.lblKompas = new System.Windows.Forms.Label();
            this.nudTent = new System.Windows.Forms.NumericUpDown();
            this.lblTent = new System.Windows.Forms.Label();
            this.nudDekzeil = new System.Windows.Forms.NumericUpDown();
            this.lblDekzeil = new System.Windows.Forms.Label();
            this.nudPeddels = new System.Windows.Forms.NumericUpDown();
            this.lblPeddels = new System.Windows.Forms.Label();
            this.nudZwemvesten = new System.Windows.Forms.NumericUpDown();
            this.lblZwemvesten = new System.Windows.Forms.Label();
            this.btnBevestigen = new System.Windows.Forms.Button();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.lblTotaalBedrag = new System.Windows.Forms.Label();
            this.gpGegevens.SuspendLayout();
            this.gbVaarplaatsen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalmeren)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).BeginInit();
            this.gbBoot.SuspendLayout();
            this.gbArtikelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKompas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDekzeil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeddels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZwemvesten)).BeginInit();
            this.SuspendLayout();
            // 
            // gpGegevens
            // 
            this.gpGegevens.Controls.Add(this.lblEinddatum);
            this.gpGegevens.Controls.Add(this.lblBegindatum);
            this.gpGegevens.Controls.Add(this.lblEmail);
            this.gpGegevens.Controls.Add(this.lblAchternaam);
            this.gpGegevens.Controls.Add(this.lblTussenvoegsel);
            this.gpGegevens.Controls.Add(this.lblVoornaam);
            this.gpGegevens.Controls.Add(this.dtpBegin);
            this.gpGegevens.Controls.Add(this.dtpEind);
            this.gpGegevens.Controls.Add(this.tbEmail);
            this.gpGegevens.Controls.Add(this.tbAchternaam);
            this.gpGegevens.Controls.Add(this.tbVoornaam);
            this.gpGegevens.Controls.Add(this.tbTussenvoegsel);
            this.gpGegevens.Location = new System.Drawing.Point(12, 12);
            this.gpGegevens.Name = "gpGegevens";
            this.gpGegevens.Size = new System.Drawing.Size(321, 255);
            this.gpGegevens.TabIndex = 0;
            this.gpGegevens.TabStop = false;
            this.gpGegevens.Text = "Gegevens";
            // 
            // lblEinddatum
            // 
            this.lblEinddatum.AutoSize = true;
            this.lblEinddatum.Location = new System.Drawing.Point(9, 222);
            this.lblEinddatum.Name = "lblEinddatum";
            this.lblEinddatum.Size = new System.Drawing.Size(63, 13);
            this.lblEinddatum.TabIndex = 11;
            this.lblEinddatum.Text = "Eind datum:";
            // 
            // lblBegindatum
            // 
            this.lblBegindatum.AutoSize = true;
            this.lblBegindatum.Location = new System.Drawing.Point(9, 188);
            this.lblBegindatum.Name = "lblBegindatum";
            this.lblBegindatum.Size = new System.Drawing.Size(69, 13);
            this.lblBegindatum.TabIndex = 10;
            this.lblBegindatum.Text = "Begin datum:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 152);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mailadres:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(9, 114);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(67, 13);
            this.lblAchternaam.TabIndex = 8;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblTussenvoegsel
            // 
            this.lblTussenvoegsel.AutoSize = true;
            this.lblTussenvoegsel.Location = new System.Drawing.Point(9, 72);
            this.lblTussenvoegsel.Name = "lblTussenvoegsel";
            this.lblTussenvoegsel.Size = new System.Drawing.Size(82, 13);
            this.lblTussenvoegsel.TabIndex = 7;
            this.lblTussenvoegsel.Text = "Tussenvoegsel:";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(9, 22);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(58, 13);
            this.lblVoornaam.TabIndex = 6;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(108, 181);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 5;
            // 
            // dtpEind
            // 
            this.dtpEind.Location = new System.Drawing.Point(108, 216);
            this.dtpEind.Name = "dtpEind";
            this.dtpEind.Size = new System.Drawing.Size(200, 20);
            this.dtpEind.TabIndex = 4;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(108, 145);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(197, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(108, 107);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(197, 20);
            this.tbAchternaam.TabIndex = 2;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(108, 19);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(197, 20);
            this.tbVoornaam.TabIndex = 1;
            // 
            // tbTussenvoegsel
            // 
            this.tbTussenvoegsel.Location = new System.Drawing.Point(108, 65);
            this.tbTussenvoegsel.Name = "tbTussenvoegsel";
            this.tbTussenvoegsel.Size = new System.Drawing.Size(197, 20);
            this.tbTussenvoegsel.TabIndex = 0;
            // 
            // gbVaarplaatsen
            // 
            this.gbVaarplaatsen.Controls.Add(this.nudAantalmeren);
            this.gbVaarplaatsen.Controls.Add(this.cbNoordzee);
            this.gbVaarplaatsen.Controls.Add(this.cbIjsselmeer);
            this.gbVaarplaatsen.Controls.Add(this.lblAantalmeren);
            this.gbVaarplaatsen.Controls.Add(this.panel1);
            this.gbVaarplaatsen.Location = new System.Drawing.Point(377, 12);
            this.gbVaarplaatsen.Name = "gbVaarplaatsen";
            this.gbVaarplaatsen.Size = new System.Drawing.Size(255, 255);
            this.gbVaarplaatsen.TabIndex = 1;
            this.gbVaarplaatsen.TabStop = false;
            this.gbVaarplaatsen.Text = "Vaarplaatsen";
            // 
            // nudAantalmeren
            // 
            this.nudAantalmeren.Location = new System.Drawing.Point(111, 216);
            this.nudAantalmeren.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudAantalmeren.Name = "nudAantalmeren";
            this.nudAantalmeren.Size = new System.Drawing.Size(56, 20);
            this.nudAantalmeren.TabIndex = 6;
            // 
            // cbNoordzee
            // 
            this.cbNoordzee.AutoSize = true;
            this.cbNoordzee.Location = new System.Drawing.Point(27, 181);
            this.cbNoordzee.Name = "cbNoordzee";
            this.cbNoordzee.Size = new System.Drawing.Size(72, 17);
            this.cbNoordzee.TabIndex = 5;
            this.cbNoordzee.Text = "Noordzee";
            this.cbNoordzee.UseVisualStyleBackColor = true;
            // 
            // cbIjsselmeer
            // 
            this.cbIjsselmeer.AutoSize = true;
            this.cbIjsselmeer.Location = new System.Drawing.Point(27, 152);
            this.cbIjsselmeer.Name = "cbIjsselmeer";
            this.cbIjsselmeer.Size = new System.Drawing.Size(72, 17);
            this.cbIjsselmeer.TabIndex = 4;
            this.cbIjsselmeer.Text = "Ijsselmeer";
            this.cbIjsselmeer.UseVisualStyleBackColor = true;
            // 
            // lblAantalmeren
            // 
            this.lblAantalmeren.AutoSize = true;
            this.lblAantalmeren.Location = new System.Drawing.Point(30, 223);
            this.lblAantalmeren.Name = "lblAantalmeren";
            this.lblAantalmeren.Size = new System.Drawing.Size(75, 13);
            this.lblAantalmeren.TabIndex = 3;
            this.lblAantalmeren.Text = "Aantal meren: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMerenMogelijk);
            this.panel1.Controls.Add(this.lblMerenMogelijk);
            this.panel1.Controls.Add(this.nudBudget);
            this.panel1.Controls.Add(this.lblBudget);
            this.panel1.Location = new System.Drawing.Point(27, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnMerenMogelijk
            // 
            this.btnMerenMogelijk.Location = new System.Drawing.Point(6, 74);
            this.btnMerenMogelijk.Name = "btnMerenMogelijk";
            this.btnMerenMogelijk.Size = new System.Drawing.Size(191, 23);
            this.btnMerenMogelijk.TabIndex = 4;
            this.btnMerenMogelijk.Text = "Bereken mogel aantal meren";
            this.btnMerenMogelijk.UseVisualStyleBackColor = true;
            this.btnMerenMogelijk.Click += new System.EventHandler(this.btnMerenMogelijk_Click);
            // 
            // lblMerenMogelijk
            // 
            this.lblMerenMogelijk.AutoSize = true;
            this.lblMerenMogelijk.Location = new System.Drawing.Point(3, 45);
            this.lblMerenMogelijk.Name = "lblMerenMogelijk";
            this.lblMerenMogelijk.Size = new System.Drawing.Size(122, 13);
            this.lblMerenMogelijk.TabIndex = 2;
            this.lblMerenMogelijk.Text = "Aantal meren mogelijk: 0";
            // 
            // nudBudget
            // 
            this.nudBudget.DecimalPlaces = 2;
            this.nudBudget.Location = new System.Drawing.Point(53, 12);
            this.nudBudget.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBudget.Name = "nudBudget";
            this.nudBudget.Size = new System.Drawing.Size(110, 20);
            this.nudBudget.TabIndex = 1;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(3, 14);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(44, 13);
            this.lblBudget.TabIndex = 0;
            this.lblBudget.Text = "Budget:";
            // 
            // gbBoot
            // 
            this.gbBoot.Controls.Add(this.lblAradius);
            this.gbBoot.Controls.Add(this.btnActieradius);
            this.gbBoot.Controls.Add(this.lblBoot);
            this.gbBoot.Controls.Add(this.cmbBoot);
            this.gbBoot.Location = new System.Drawing.Point(12, 287);
            this.gbBoot.Name = "gbBoot";
            this.gbBoot.Size = new System.Drawing.Size(186, 238);
            this.gbBoot.TabIndex = 2;
            this.gbBoot.TabStop = false;
            this.gbBoot.Text = "Boot";
            // 
            // lblAradius
            // 
            this.lblAradius.AutoSize = true;
            this.lblAradius.Location = new System.Drawing.Point(25, 130);
            this.lblAradius.Name = "lblAradius";
            this.lblAradius.Size = new System.Drawing.Size(0, 13);
            this.lblAradius.TabIndex = 24;
            // 
            // btnActieradius
            // 
            this.btnActieradius.Location = new System.Drawing.Point(74, 88);
            this.btnActieradius.Name = "btnActieradius";
            this.btnActieradius.Size = new System.Drawing.Size(75, 23);
            this.btnActieradius.TabIndex = 4;
            this.btnActieradius.Text = "Actieradius";
            this.btnActieradius.UseVisualStyleBackColor = true;
            this.btnActieradius.Click += new System.EventHandler(this.btnActieradius_Click);
            // 
            // lblBoot
            // 
            this.lblBoot.AutoSize = true;
            this.lblBoot.Location = new System.Drawing.Point(25, 45);
            this.lblBoot.Name = "lblBoot";
            this.lblBoot.Size = new System.Drawing.Size(29, 13);
            this.lblBoot.TabIndex = 12;
            this.lblBoot.Text = "Boot";
            // 
            // cmbBoot
            // 
            this.cmbBoot.FormattingEnabled = true;
            this.cmbBoot.Location = new System.Drawing.Point(28, 61);
            this.cmbBoot.Name = "cmbBoot";
            this.cmbBoot.Size = new System.Drawing.Size(121, 21);
            this.cmbBoot.TabIndex = 0;
            // 
            // gbArtikelen
            // 
            this.gbArtikelen.Controls.Add(this.nudKompas);
            this.gbArtikelen.Controls.Add(this.lblKompas);
            this.gbArtikelen.Controls.Add(this.nudTent);
            this.gbArtikelen.Controls.Add(this.lblTent);
            this.gbArtikelen.Controls.Add(this.nudDekzeil);
            this.gbArtikelen.Controls.Add(this.lblDekzeil);
            this.gbArtikelen.Controls.Add(this.nudPeddels);
            this.gbArtikelen.Controls.Add(this.lblPeddels);
            this.gbArtikelen.Controls.Add(this.nudZwemvesten);
            this.gbArtikelen.Controls.Add(this.lblZwemvesten);
            this.gbArtikelen.Location = new System.Drawing.Point(215, 287);
            this.gbArtikelen.Name = "gbArtikelen";
            this.gbArtikelen.Size = new System.Drawing.Size(139, 238);
            this.gbArtikelen.TabIndex = 3;
            this.gbArtikelen.TabStop = false;
            this.gbArtikelen.Text = "Artikelen";
            // 
            // nudKompas
            // 
            this.nudKompas.Location = new System.Drawing.Point(83, 149);
            this.nudKompas.Name = "nudKompas";
            this.nudKompas.Size = new System.Drawing.Size(50, 20);
            this.nudKompas.TabIndex = 22;
            // 
            // lblKompas
            // 
            this.lblKompas.AutoSize = true;
            this.lblKompas.Location = new System.Drawing.Point(6, 151);
            this.lblKompas.Name = "lblKompas";
            this.lblKompas.Size = new System.Drawing.Size(45, 13);
            this.lblKompas.TabIndex = 21;
            this.lblKompas.Text = "Kompas";
            // 
            // nudTent
            // 
            this.nudTent.Location = new System.Drawing.Point(83, 123);
            this.nudTent.Name = "nudTent";
            this.nudTent.Size = new System.Drawing.Size(50, 20);
            this.nudTent.TabIndex = 20;
            // 
            // lblTent
            // 
            this.lblTent.AutoSize = true;
            this.lblTent.Location = new System.Drawing.Point(6, 125);
            this.lblTent.Name = "lblTent";
            this.lblTent.Size = new System.Drawing.Size(32, 13);
            this.lblTent.TabIndex = 19;
            this.lblTent.Text = "Tent:";
            // 
            // nudDekzeil
            // 
            this.nudDekzeil.Location = new System.Drawing.Point(83, 97);
            this.nudDekzeil.Name = "nudDekzeil";
            this.nudDekzeil.Size = new System.Drawing.Size(50, 20);
            this.nudDekzeil.TabIndex = 18;
            // 
            // lblDekzeil
            // 
            this.lblDekzeil.AutoSize = true;
            this.lblDekzeil.Location = new System.Drawing.Point(6, 99);
            this.lblDekzeil.Name = "lblDekzeil";
            this.lblDekzeil.Size = new System.Drawing.Size(45, 13);
            this.lblDekzeil.TabIndex = 17;
            this.lblDekzeil.Text = "Dekzeil:";
            // 
            // nudPeddels
            // 
            this.nudPeddels.Location = new System.Drawing.Point(83, 71);
            this.nudPeddels.Name = "nudPeddels";
            this.nudPeddels.Size = new System.Drawing.Size(50, 20);
            this.nudPeddels.TabIndex = 16;
            // 
            // lblPeddels
            // 
            this.lblPeddels.AutoSize = true;
            this.lblPeddels.Location = new System.Drawing.Point(6, 73);
            this.lblPeddels.Name = "lblPeddels";
            this.lblPeddels.Size = new System.Drawing.Size(48, 13);
            this.lblPeddels.TabIndex = 15;
            this.lblPeddels.Text = "Peddels:";
            // 
            // nudZwemvesten
            // 
            this.nudZwemvesten.Location = new System.Drawing.Point(83, 45);
            this.nudZwemvesten.Name = "nudZwemvesten";
            this.nudZwemvesten.Size = new System.Drawing.Size(50, 20);
            this.nudZwemvesten.TabIndex = 14;
            // 
            // lblZwemvesten
            // 
            this.lblZwemvesten.AutoSize = true;
            this.lblZwemvesten.Location = new System.Drawing.Point(6, 45);
            this.lblZwemvesten.Name = "lblZwemvesten";
            this.lblZwemvesten.Size = new System.Drawing.Size(71, 13);
            this.lblZwemvesten.TabIndex = 13;
            this.lblZwemvesten.Text = "Zwemvesten:";
            // 
            // btnBevestigen
            // 
            this.btnBevestigen.Location = new System.Drawing.Point(377, 504);
            this.btnBevestigen.Name = "btnBevestigen";
            this.btnBevestigen.Size = new System.Drawing.Size(146, 21);
            this.btnBevestigen.TabIndex = 5;
            this.btnBevestigen.Text = "Huurcontract bevestigen";
            this.btnBevestigen.UseVisualStyleBackColor = true;
            this.btnBevestigen.Click += new System.EventHandler(this.btnBevestigen_Click);
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(554, 504);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(91, 21);
            this.btnAnnuleren.TabIndex = 6;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // lblTotaalBedrag
            // 
            this.lblTotaalBedrag.AutoSize = true;
            this.lblTotaalBedrag.Location = new System.Drawing.Point(380, 473);
            this.lblTotaalBedrag.Name = "lblTotaalBedrag";
            this.lblTotaalBedrag.Size = new System.Drawing.Size(109, 13);
            this.lblTotaalBedrag.TabIndex = 23;
            this.lblTotaalBedrag.Text = "Totaal bedrag: € 0.00";
            // 
            // FormNieuwHuurcontract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 533);
            this.Controls.Add(this.lblTotaalBedrag);
            this.Controls.Add(this.btnAnnuleren);
            this.Controls.Add(this.btnBevestigen);
            this.Controls.Add(this.gbArtikelen);
            this.Controls.Add(this.gbBoot);
            this.Controls.Add(this.gbVaarplaatsen);
            this.Controls.Add(this.gpGegevens);
            this.Name = "FormNieuwHuurcontract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'T Sloepke - NieuwHuurcontract";
            this.gpGegevens.ResumeLayout(false);
            this.gpGegevens.PerformLayout();
            this.gbVaarplaatsen.ResumeLayout(false);
            this.gbVaarplaatsen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAantalmeren)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBudget)).EndInit();
            this.gbBoot.ResumeLayout(false);
            this.gbBoot.PerformLayout();
            this.gbArtikelen.ResumeLayout(false);
            this.gbArtikelen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKompas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDekzeil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeddels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZwemvesten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpGegevens;
        private System.Windows.Forms.DateTimePicker dtpEind;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.TextBox tbTussenvoegsel;
        private System.Windows.Forms.GroupBox gbVaarplaatsen;
        private System.Windows.Forms.GroupBox gbBoot;
        private System.Windows.Forms.GroupBox gbArtikelen;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblTussenvoegsel;
        private System.Windows.Forms.Label lblEinddatum;
        private System.Windows.Forms.Label lblBegindatum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBoot;
        private System.Windows.Forms.ComboBox cmbBoot;
        private System.Windows.Forms.Button btnActieradius;
        private System.Windows.Forms.NumericUpDown nudAantalmeren;
        private System.Windows.Forms.CheckBox cbNoordzee;
        private System.Windows.Forms.CheckBox cbIjsselmeer;
        private System.Windows.Forms.Label lblAantalmeren;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMerenMogelijk;
        private System.Windows.Forms.Label lblMerenMogelijk;
        private System.Windows.Forms.NumericUpDown nudBudget;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.NumericUpDown nudPeddels;
        private System.Windows.Forms.Label lblPeddels;
        private System.Windows.Forms.NumericUpDown nudZwemvesten;
        private System.Windows.Forms.Label lblZwemvesten;
        private System.Windows.Forms.Button btnBevestigen;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.NumericUpDown nudTent;
        private System.Windows.Forms.Label lblTent;
        private System.Windows.Forms.NumericUpDown nudDekzeil;
        private System.Windows.Forms.Label lblDekzeil;
        private System.Windows.Forms.NumericUpDown nudKompas;
        private System.Windows.Forms.Label lblKompas;
        private System.Windows.Forms.Label lblTotaalBedrag;
        private System.Windows.Forms.Label lblAradius;
    }
}