namespace ProjectPaardRacing
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnbankenrekening = new System.Windows.Forms.Button();
            this.btnOpenmarkt = new System.Windows.Forms.Button();
            this.btnRacebaan = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.lblgebruiker = new System.Windows.Forms.Label();
            this.lblbalans = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.btnstallen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbankenrekening
            // 
            this.btnbankenrekening.Location = new System.Drawing.Point(12, 37);
            this.btnbankenrekening.Name = "btnbankenrekening";
            this.btnbankenrekening.Size = new System.Drawing.Size(144, 55);
            this.btnbankenrekening.TabIndex = 0;
            this.btnbankenrekening.Text = "Bank";
            this.btnbankenrekening.UseVisualStyleBackColor = true;
            this.btnbankenrekening.Click += new System.EventHandler(this.Btnbankenrekening_Click);
            // 
            // btnOpenmarkt
            // 
            this.btnOpenmarkt.Location = new System.Drawing.Point(12, 98);
            this.btnOpenmarkt.Name = "btnOpenmarkt";
            this.btnOpenmarkt.Size = new System.Drawing.Size(144, 55);
            this.btnOpenmarkt.TabIndex = 1;
            this.btnOpenmarkt.Text = "Open Markt";
            this.btnOpenmarkt.UseVisualStyleBackColor = true;
            this.btnOpenmarkt.Click += new System.EventHandler(this.BtnOpenmarkt_Click);
            // 
            // btnRacebaan
            // 
            this.btnRacebaan.Location = new System.Drawing.Point(12, 159);
            this.btnRacebaan.Name = "btnRacebaan";
            this.btnRacebaan.Size = new System.Drawing.Size(144, 55);
            this.btnRacebaan.TabIndex = 2;
            this.btnRacebaan.Text = "Racebaan";
            this.btnRacebaan.UseVisualStyleBackColor = true;
            this.btnRacebaan.Click += new System.EventHandler(this.BtnRacebaan_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 281);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(144, 55);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // lblgebruiker
            // 
            this.lblgebruiker.AutoSize = true;
            this.lblgebruiker.BackColor = System.Drawing.Color.Transparent;
            this.lblgebruiker.Location = new System.Drawing.Point(244, 110);
            this.lblgebruiker.Name = "lblgebruiker";
            this.lblgebruiker.Size = new System.Drawing.Size(56, 13);
            this.lblgebruiker.TabIndex = 4;
            this.lblgebruiker.Text = "Gebruiker:";
            // 
            // lblbalans
            // 
            this.lblbalans.AutoSize = true;
            this.lblbalans.Location = new System.Drawing.Point(244, 152);
            this.lblbalans.Name = "lblbalans";
            this.lblbalans.Size = new System.Drawing.Size(37, 13);
            this.lblbalans.TabIndex = 5;
            this.lblbalans.Text = "Saldo:";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(244, 192);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(38, 13);
            this.lblscore.TabIndex = 6;
            this.lblscore.Text = "Score:";
            // 
            // btnstallen
            // 
            this.btnstallen.Location = new System.Drawing.Point(12, 220);
            this.btnstallen.Name = "btnstallen";
            this.btnstallen.Size = new System.Drawing.Size(144, 55);
            this.btnstallen.TabIndex = 8;
            this.btnstallen.Text = "Stallen";
            this.btnstallen.UseVisualStyleBackColor = true;
            this.btnstallen.Click += new System.EventHandler(this.btnstallen_Click);
            // 
            // frmGame
            // 
            this.ClientSize = new System.Drawing.Size(653, 364);
            this.Controls.Add(this.btnstallen);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblbalans);
            this.Controls.Add(this.lblgebruiker);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRacebaan);
            this.Controls.Add(this.btnOpenmarkt);
            this.Controls.Add(this.btnbankenrekening);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.frmGame_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbank;
        private System.Windows.Forms.Button btnrace;
        private System.Windows.Forms.Button btnmarkt;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnbankenrekening;
        private System.Windows.Forms.Button btnOpenmarkt;
        private System.Windows.Forms.Button btnRacebaan;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Label lblgebruiker;
        private System.Windows.Forms.Label lblbalans;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Button btnstallen;
    }
}