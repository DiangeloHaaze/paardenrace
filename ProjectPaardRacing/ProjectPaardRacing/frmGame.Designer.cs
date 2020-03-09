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
            this.btnstallen = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoEuro = new System.Windows.Forms.Label();
            this.lblGebruikersnaam = new System.Windows.Forms.Label();
            this.lblGewonnen = new System.Windows.Forms.Label();
            this.lblVerloren = new System.Windows.Forms.Label();
            this.lblGewonnenAant = new System.Windows.Forms.Label();
            this.lblVerlorenAant = new System.Windows.Forms.Label();
            this.lblWedstrijden = new System.Windows.Forms.Label();
            this.lblWedstrijdenAantal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbankenrekening
            // 
            this.btnbankenrekening.Location = new System.Drawing.Point(12, 12);
            this.btnbankenrekening.Name = "btnbankenrekening";
            this.btnbankenrekening.Size = new System.Drawing.Size(144, 55);
            this.btnbankenrekening.TabIndex = 0;
            this.btnbankenrekening.Text = "Bank";
            this.btnbankenrekening.UseVisualStyleBackColor = true;
            this.btnbankenrekening.Click += new System.EventHandler(this.Btnbankenrekening_Click);
            // 
            // btnOpenmarkt
            // 
            this.btnOpenmarkt.Location = new System.Drawing.Point(12, 73);
            this.btnOpenmarkt.Name = "btnOpenmarkt";
            this.btnOpenmarkt.Size = new System.Drawing.Size(144, 55);
            this.btnOpenmarkt.TabIndex = 1;
            this.btnOpenmarkt.Text = "Open Markt";
            this.btnOpenmarkt.UseVisualStyleBackColor = true;
            this.btnOpenmarkt.Click += new System.EventHandler(this.BtnOpenmarkt_Click);
            // 
            // btnRacebaan
            // 
            this.btnRacebaan.Location = new System.Drawing.Point(12, 134);
            this.btnRacebaan.Name = "btnRacebaan";
            this.btnRacebaan.Size = new System.Drawing.Size(144, 55);
            this.btnRacebaan.TabIndex = 2;
            this.btnRacebaan.Text = "Racebaan";
            this.btnRacebaan.UseVisualStyleBackColor = true;
            this.btnRacebaan.Click += new System.EventHandler(this.BtnRacebaan_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 256);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(144, 55);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.BtnTerug_Click);
            // 
            // btnstallen
            // 
            this.btnstallen.Location = new System.Drawing.Point(12, 195);
            this.btnstallen.Name = "btnstallen";
            this.btnstallen.Size = new System.Drawing.Size(144, 55);
            this.btnstallen.TabIndex = 4;
            this.btnstallen.Text = "Stallen";
            this.btnstallen.UseVisualStyleBackColor = true;
            this.btnstallen.Click += new System.EventHandler(this.btnstallen_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(507, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoEuro
            // 
            this.lblSaldoEuro.AutoSize = true;
            this.lblSaldoEuro.Location = new System.Drawing.Point(550, 9);
            this.lblSaldoEuro.Name = "lblSaldoEuro";
            this.lblSaldoEuro.Size = new System.Drawing.Size(40, 13);
            this.lblSaldoEuro.TabIndex = 9;
            this.lblSaldoEuro.Text = "bedrag";
            // 
            // lblGebruikersnaam
            // 
            this.lblGebruikersnaam.AutoSize = true;
            this.lblGebruikersnaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikersnaam.Location = new System.Drawing.Point(269, 42);
            this.lblGebruikersnaam.Name = "lblGebruikersnaam";
            this.lblGebruikersnaam.Size = new System.Drawing.Size(184, 25);
            this.lblGebruikersnaam.TabIndex = 5;
            this.lblGebruikersnaam.Text = "Gebruikersnaam";
            // 
            // lblGewonnen
            // 
            this.lblGewonnen.AutoSize = true;
            this.lblGewonnen.Location = new System.Drawing.Point(273, 162);
            this.lblGewonnen.Name = "lblGewonnen";
            this.lblGewonnen.Size = new System.Drawing.Size(149, 13);
            this.lblGewonnen.TabIndex = 12;
            this.lblGewonnen.Text = "Aantal gewonnen wedstrijden:";
            // 
            // lblVerloren
            // 
            this.lblVerloren.AutoSize = true;
            this.lblVerloren.Location = new System.Drawing.Point(285, 209);
            this.lblVerloren.Name = "lblVerloren";
            this.lblVerloren.Size = new System.Drawing.Size(137, 13);
            this.lblVerloren.TabIndex = 13;
            this.lblVerloren.Text = "Aantal verloren wedstrijden:";
            // 
            // lblGewonnenAant
            // 
            this.lblGewonnenAant.AutoSize = true;
            this.lblGewonnenAant.Location = new System.Drawing.Point(429, 162);
            this.lblGewonnenAant.Name = "lblGewonnenAant";
            this.lblGewonnenAant.Size = new System.Drawing.Size(13, 13);
            this.lblGewonnenAant.TabIndex = 14;
            this.lblGewonnenAant.Text = "0";
            // 
            // lblVerlorenAant
            // 
            this.lblVerlorenAant.AutoSize = true;
            this.lblVerlorenAant.Location = new System.Drawing.Point(429, 209);
            this.lblVerlorenAant.Name = "lblVerlorenAant";
            this.lblVerlorenAant.Size = new System.Drawing.Size(13, 13);
            this.lblVerlorenAant.TabIndex = 15;
            this.lblVerlorenAant.Text = "0";
            // 
            // lblWedstrijden
            // 
            this.lblWedstrijden.AutoSize = true;
            this.lblWedstrijden.Location = new System.Drawing.Point(273, 115);
            this.lblWedstrijden.Name = "lblWedstrijden";
            this.lblWedstrijden.Size = new System.Drawing.Size(148, 13);
            this.lblWedstrijden.TabIndex = 16;
            this.lblWedstrijden.Text = "Aantal gespeelde wedstrijden:";
            // 
            // lblWedstrijdenAantal
            // 
            this.lblWedstrijdenAantal.AutoSize = true;
            this.lblWedstrijdenAantal.Location = new System.Drawing.Point(428, 115);
            this.lblWedstrijdenAantal.Name = "lblWedstrijdenAantal";
            this.lblWedstrijdenAantal.Size = new System.Drawing.Size(13, 13);
            this.lblWedstrijdenAantal.TabIndex = 17;
            this.lblWedstrijdenAantal.Text = "0";
            // 
            // frmGame
            // 
            this.ClientSize = new System.Drawing.Size(605, 369);
            this.Controls.Add(this.lblWedstrijdenAantal);
            this.Controls.Add(this.lblWedstrijden);
            this.Controls.Add(this.lblVerlorenAant);
            this.Controls.Add(this.lblGewonnenAant);
            this.Controls.Add(this.lblVerloren);
            this.Controls.Add(this.lblGewonnen);
            this.Controls.Add(this.lblSaldoEuro);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblGebruikersnaam);
            this.Controls.Add(this.btnstallen);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRacebaan);
            this.Controls.Add(this.btnOpenmarkt);
            this.Controls.Add(this.btnbankenrekening);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.FrmGame_Load_1);
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
        private System.Windows.Forms.Button btnstallen;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoEuro;
        private System.Windows.Forms.Label lblGebruikersnaam;
        private System.Windows.Forms.Label lblGewonnen;
        private System.Windows.Forms.Label lblVerloren;
        private System.Windows.Forms.Label lblGewonnenAant;
        private System.Windows.Forms.Label lblVerlorenAant;
        private System.Windows.Forms.Label lblWedstrijden;
        private System.Windows.Forms.Label lblWedstrijdenAantal;
    }
}