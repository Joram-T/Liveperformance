namespace T_Sloepke.Forms
{
    partial class FormHuurcontracten
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
            this.lvHuurcontract = new System.Windows.Forms.ListView();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblHuurcontracten = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvHuurcontract
            // 
            this.lvHuurcontract.Location = new System.Drawing.Point(12, 31);
            this.lvHuurcontract.Name = "lvHuurcontract";
            this.lvHuurcontract.Size = new System.Drawing.Size(628, 394);
            this.lvHuurcontract.TabIndex = 0;
            this.lvHuurcontract.UseCompatibleStateImageBehavior = false;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(565, 431);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 1;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // lblHuurcontracten
            // 
            this.lblHuurcontracten.AutoSize = true;
            this.lblHuurcontracten.Location = new System.Drawing.Point(12, 15);
            this.lblHuurcontracten.Name = "lblHuurcontracten";
            this.lblHuurcontracten.Size = new System.Drawing.Size(81, 13);
            this.lblHuurcontracten.TabIndex = 2;
            this.lblHuurcontracten.Text = "Huurcontracten";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(12, 431);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export contracten";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormHuurcontracten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 462);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblHuurcontracten);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lvHuurcontract);
            this.Name = "FormHuurcontracten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huurcontracten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvHuurcontract;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblHuurcontracten;
        private System.Windows.Forms.Button btnExport;
    }
}