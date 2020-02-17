namespace ProjectPaardRacing
{
    partial class frmSettings
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
            this.gpbkleur = new System.Windows.Forms.GroupBox();
            this.rdbgeel = new System.Windows.Forms.RadioButton();
            this.rdbrood = new System.Windows.Forms.RadioButton();
            this.rdbblauw = new System.Windows.Forms.RadioButton();
            this.rdbgroen = new System.Windows.Forms.RadioButton();
            this.rdbgrijs = new System.Windows.Forms.RadioButton();
            this.lblgebruiker = new System.Windows.Forms.Label();
            this.txtgebruiker = new System.Windows.Forms.TextBox();
            this.btnterug = new System.Windows.Forms.Button();
            this.gpbkleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbkleur
            // 
            this.gpbkleur.BackColor = System.Drawing.Color.LightCoral;
            this.gpbkleur.Controls.Add(this.rdbgrijs);
            this.gpbkleur.Controls.Add(this.rdbgroen);
            this.gpbkleur.Controls.Add(this.rdbblauw);
            this.gpbkleur.Controls.Add(this.rdbrood);
            this.gpbkleur.Controls.Add(this.rdbgeel);
            this.gpbkleur.Location = new System.Drawing.Point(12, 54);
            this.gpbkleur.Name = "gpbkleur";
            this.gpbkleur.Size = new System.Drawing.Size(105, 143);
            this.gpbkleur.TabIndex = 0;
            this.gpbkleur.TabStop = false;
            this.gpbkleur.Text = "Achtergrond kleur";
            // 
            // rdbgeel
            // 
            this.rdbgeel.AutoSize = true;
            this.rdbgeel.Location = new System.Drawing.Point(6, 19);
            this.rdbgeel.Name = "rdbgeel";
            this.rdbgeel.Size = new System.Drawing.Size(47, 17);
            this.rdbgeel.TabIndex = 0;
            this.rdbgeel.Text = "Geel";
            this.rdbgeel.UseVisualStyleBackColor = true;
            this.rdbgeel.CheckedChanged += new System.EventHandler(this.Rdbgeel_CheckedChanged);
            // 
            // rdbrood
            // 
            this.rdbrood.AutoSize = true;
            this.rdbrood.Location = new System.Drawing.Point(6, 42);
            this.rdbrood.Name = "rdbrood";
            this.rdbrood.Size = new System.Drawing.Size(51, 17);
            this.rdbrood.TabIndex = 1;
            this.rdbrood.Text = "Rood";
            this.rdbrood.UseVisualStyleBackColor = true;
            // 
            // rdbblauw
            // 
            this.rdbblauw.AutoSize = true;
            this.rdbblauw.Location = new System.Drawing.Point(6, 65);
            this.rdbblauw.Name = "rdbblauw";
            this.rdbblauw.Size = new System.Drawing.Size(54, 17);
            this.rdbblauw.TabIndex = 2;
            this.rdbblauw.Text = "Blauw";
            this.rdbblauw.UseVisualStyleBackColor = true;
            // 
            // rdbgroen
            // 
            this.rdbgroen.AutoSize = true;
            this.rdbgroen.Location = new System.Drawing.Point(6, 88);
            this.rdbgroen.Name = "rdbgroen";
            this.rdbgroen.Size = new System.Drawing.Size(54, 17);
            this.rdbgroen.TabIndex = 3;
            this.rdbgroen.Text = "Groen";
            this.rdbgroen.UseVisualStyleBackColor = true;
            // 
            // rdbgrijs
            // 
            this.rdbgrijs.AutoSize = true;
            this.rdbgrijs.Checked = true;
            this.rdbgrijs.Location = new System.Drawing.Point(6, 111);
            this.rdbgrijs.Name = "rdbgrijs";
            this.rdbgrijs.Size = new System.Drawing.Size(45, 17);
            this.rdbgrijs.TabIndex = 4;
            this.rdbgrijs.TabStop = true;
            this.rdbgrijs.Text = "Grijs";
            this.rdbgrijs.UseVisualStyleBackColor = true;
            this.rdbgrijs.CheckedChanged += new System.EventHandler(this.Rdbgrijs_CheckedChanged);
            // 
            // lblgebruiker
            // 
            this.lblgebruiker.AutoSize = true;
            this.lblgebruiker.Location = new System.Drawing.Point(15, 28);
            this.lblgebruiker.Name = "lblgebruiker";
            this.lblgebruiker.Size = new System.Drawing.Size(35, 13);
            this.lblgebruiker.TabIndex = 1;
            this.lblgebruiker.Text = "Naam";
            // 
            // txtgebruiker
            // 
            this.txtgebruiker.Location = new System.Drawing.Point(56, 28);
            this.txtgebruiker.Name = "txtgebruiker";
            this.txtgebruiker.Size = new System.Drawing.Size(100, 20);
            this.txtgebruiker.TabIndex = 2;
            this.txtgebruiker.TextChanged += new System.EventHandler(this.Txtgebruiker_TextChanged);
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(42, 245);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(114, 56);
            this.btnterug.TabIndex = 3;
            this.btnterug.Text = "Ga terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.Btnterug_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 455);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.txtgebruiker);
            this.Controls.Add(this.lblgebruiker);
            this.Controls.Add(this.gpbkleur);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gpbkleur.ResumeLayout(false);
            this.gpbkleur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbkleur;
        private System.Windows.Forms.RadioButton rdbgrijs;
        private System.Windows.Forms.RadioButton rdbgroen;
        private System.Windows.Forms.RadioButton rdbblauw;
        private System.Windows.Forms.RadioButton rdbrood;
        private System.Windows.Forms.RadioButton rdbgeel;
        private System.Windows.Forms.Label lblgebruiker;
        private System.Windows.Forms.TextBox txtgebruiker;
        private System.Windows.Forms.Button btnterug;
    }
}