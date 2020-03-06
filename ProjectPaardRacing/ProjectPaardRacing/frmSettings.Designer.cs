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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gpbkleur = new System.Windows.Forms.GroupBox();
            this.rdbgrijs = new System.Windows.Forms.RadioButton();
            this.rdbgroen = new System.Windows.Forms.RadioButton();
            this.rdbblauw = new System.Windows.Forms.RadioButton();
            this.rdbrood = new System.Windows.Forms.RadioButton();
            this.rdbgeel = new System.Windows.Forms.RadioButton();
            this.lblgebruiker = new System.Windows.Forms.Label();
            this.txtgebruiker = new System.Windows.Forms.TextBox();
            this.btnterug = new System.Windows.Forms.Button();
            this.gpbmuziek = new System.Windows.Forms.GroupBox();
            this.rdbsong3 = new System.Windows.Forms.RadioButton();
            this.rdbsong2 = new System.Windows.Forms.RadioButton();
            this.rdbsong1 = new System.Windows.Forms.RadioButton();
            this.rdbgeen = new System.Windows.Forms.RadioButton();
            this.btnreset = new System.Windows.Forms.Button();
            this.gpbkleur.SuspendLayout();
            this.gpbmuziek.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbkleur
            // 
            this.gpbkleur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbkleur.Controls.Add(this.rdbgrijs);
            this.gpbkleur.Controls.Add(this.rdbgroen);
            this.gpbkleur.Controls.Add(this.rdbblauw);
            this.gpbkleur.Controls.Add(this.rdbrood);
            this.gpbkleur.Controls.Add(this.rdbgeel);
            this.gpbkleur.Location = new System.Drawing.Point(12, 54);
            this.gpbkleur.Name = "gpbkleur";
            this.gpbkleur.Size = new System.Drawing.Size(129, 143);
            this.gpbkleur.TabIndex = 0;
            this.gpbkleur.TabStop = false;
            this.gpbkleur.Text = "Achtergrond kleur";
            // 
            // rdbgrijs
            // 
            this.rdbgrijs.AutoSize = true;
            this.rdbgrijs.Location = new System.Drawing.Point(6, 111);
            this.rdbgrijs.Name = "rdbgrijs";
            this.rdbgrijs.Size = new System.Drawing.Size(45, 17);
            this.rdbgrijs.TabIndex = 4;
            this.rdbgrijs.Text = "Grijs";
            this.rdbgrijs.UseVisualStyleBackColor = true;
            this.rdbgrijs.CheckedChanged += new System.EventHandler(this.Rdbgrijs_CheckedChanged);
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
            this.rdbgroen.CheckedChanged += new System.EventHandler(this.rdbgroen_CheckedChanged);
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
            this.rdbblauw.CheckedChanged += new System.EventHandler(this.rdbblauw_CheckedChanged);
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
            this.rdbrood.CheckedChanged += new System.EventHandler(this.rdbrood_CheckedChanged);
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
            this.btnterug.Location = new System.Drawing.Point(12, 377);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(114, 56);
            this.btnterug.TabIndex = 3;
            this.btnterug.Text = "Ga terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.Btnterug_Click);
            // 
            // gpbmuziek
            // 
            this.gpbmuziek.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gpbmuziek.Controls.Add(this.rdbgeen);
            this.gpbmuziek.Controls.Add(this.rdbsong3);
            this.gpbmuziek.Controls.Add(this.rdbsong2);
            this.gpbmuziek.Controls.Add(this.rdbsong1);
            this.gpbmuziek.Location = new System.Drawing.Point(12, 203);
            this.gpbmuziek.Name = "gpbmuziek";
            this.gpbmuziek.Size = new System.Drawing.Size(155, 114);
            this.gpbmuziek.TabIndex = 5;
            this.gpbmuziek.TabStop = false;
            this.gpbmuziek.Text = "Achtergrondmuziek";
            this.gpbmuziek.Enter += new System.EventHandler(this.gpbmuziek_Enter);
            // 
            // rdbsong3
            // 
            this.rdbsong3.AutoSize = true;
            this.rdbsong3.Location = new System.Drawing.Point(6, 65);
            this.rdbsong3.Name = "rdbsong3";
            this.rdbsong3.Size = new System.Drawing.Size(141, 17);
            this.rdbsong3.TabIndex = 2;
            this.rdbsong3.Text = "Sibelius Andente Festivo";
            this.rdbsong3.UseVisualStyleBackColor = true;
            this.rdbsong3.CheckedChanged += new System.EventHandler(this.rdbsong3_CheckedChanged);
            // 
            // rdbsong2
            // 
            this.rdbsong2.AutoSize = true;
            this.rdbsong2.Location = new System.Drawing.Point(6, 42);
            this.rdbsong2.Name = "rdbsong2";
            this.rdbsong2.Size = new System.Drawing.Size(89, 17);
            this.rdbsong2.TabIndex = 1;
            this.rdbsong2.Text = "Vivaldi Spring";
            this.rdbsong2.UseVisualStyleBackColor = true;
            this.rdbsong2.CheckedChanged += new System.EventHandler(this.rdbsong2_CheckedChanged);
            // 
            // rdbsong1
            // 
            this.rdbsong1.AutoSize = true;
            this.rdbsong1.Location = new System.Drawing.Point(6, 19);
            this.rdbsong1.Name = "rdbsong1";
            this.rdbsong1.Size = new System.Drawing.Size(108, 17);
            this.rdbsong1.TabIndex = 0;
            this.rdbsong1.Text = "Radetzky Marsch";
            this.rdbsong1.UseVisualStyleBackColor = true;
            this.rdbsong1.CheckedChanged += new System.EventHandler(this.rdbsong1_CheckedChanged);
            // 
            // rdbgeen
            // 
            this.rdbgeen.AutoSize = true;
            this.rdbgeen.Location = new System.Drawing.Point(6, 88);
            this.rdbgeen.Name = "rdbgeen";
            this.rdbgeen.Size = new System.Drawing.Size(51, 17);
            this.rdbgeen.TabIndex = 3;
            this.rdbgeen.Text = "Geen";
            this.rdbgeen.UseVisualStyleBackColor = true;
            this.rdbgeen.CheckedChanged += new System.EventHandler(this.rdbgeen_CheckedChanged);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(179, 377);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(114, 56);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset Spel";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 455);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.gpbmuziek);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.txtgebruiker);
            this.Controls.Add(this.lblgebruiker);
            this.Controls.Add(this.gpbkleur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gpbkleur.ResumeLayout(false);
            this.gpbkleur.PerformLayout();
            this.gpbmuziek.ResumeLayout(false);
            this.gpbmuziek.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbmuziek;
        private System.Windows.Forms.RadioButton rdbsong3;
        private System.Windows.Forms.RadioButton rdbsong2;
        private System.Windows.Forms.RadioButton rdbsong1;
        private System.Windows.Forms.RadioButton rdbgeen;
        private System.Windows.Forms.Button btnreset;
    }
}