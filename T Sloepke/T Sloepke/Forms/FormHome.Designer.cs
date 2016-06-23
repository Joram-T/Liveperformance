namespace T_Sloepke.Forms
{
    partial class FormHome
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
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnBestaand = new System.Windows.Forms.Button();
            this.btnTempratuur = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNieuw
            // 
            this.btnNieuw.Location = new System.Drawing.Point(79, 76);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(203, 143);
            this.btnNieuw.TabIndex = 0;
            this.btnNieuw.Text = "Nieuw Huurcontract";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnBestaand
            // 
            this.btnBestaand.Location = new System.Drawing.Point(435, 76);
            this.btnBestaand.Name = "btnBestaand";
            this.btnBestaand.Size = new System.Drawing.Size(203, 143);
            this.btnBestaand.TabIndex = 1;
            this.btnBestaand.Text = "Bestaande Huurcontracten";
            this.btnBestaand.UseVisualStyleBackColor = true;
            this.btnBestaand.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTempratuur
            // 
            this.btnTempratuur.Location = new System.Drawing.Point(250, 306);
            this.btnTempratuur.Name = "btnTempratuur";
            this.btnTempratuur.Size = new System.Drawing.Size(203, 143);
            this.btnTempratuur.TabIndex = 2;
            this.btnTempratuur.Text = "Tempraturen";
            this.btnTempratuur.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(563, 441);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(151, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Inloggen als admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 476);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnTempratuur);
            this.Controls.Add(this.btnBestaand);
            this.Controls.Add(this.btnNieuw);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'T Sloepke - Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnBestaand;
        private System.Windows.Forms.Button btnTempratuur;
        private System.Windows.Forms.Button btnAdmin;
    }
}