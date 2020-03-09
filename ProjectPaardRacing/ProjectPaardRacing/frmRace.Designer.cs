namespace ProjectPaardRacing
{
    partial class frmRace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRace));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInzetten = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoBedrag = new System.Windows.Forms.Label();
            this.lblInzetten = new System.Windows.Forms.Label();
            this.btnInzetten = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(411, 417);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInzetten
            // 
            this.txtInzetten.Location = new System.Drawing.Point(90, 429);
            this.txtInzetten.Name = "txtInzetten";
            this.txtInzetten.Size = new System.Drawing.Size(100, 20);
            this.txtInzetten.TabIndex = 2;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 382);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoBedrag
            // 
            this.lblSaldoBedrag.AutoSize = true;
            this.lblSaldoBedrag.Location = new System.Drawing.Point(56, 382);
            this.lblSaldoBedrag.Name = "lblSaldoBedrag";
            this.lblSaldoBedrag.Size = new System.Drawing.Size(13, 13);
            this.lblSaldoBedrag.TabIndex = 4;
            this.lblSaldoBedrag.Text = "0";
            // 
            // lblInzetten
            // 
            this.lblInzetten.AutoSize = true;
            this.lblInzetten.Location = new System.Drawing.Point(12, 432);
            this.lblInzetten.Name = "lblInzetten";
            this.lblInzetten.Size = new System.Drawing.Size(72, 13);
            this.lblInzetten.TabIndex = 5;
            this.lblInzetten.Text = "Geld inzetten:";
            // 
            // btnInzetten
            // 
            this.btnInzetten.Location = new System.Drawing.Point(203, 428);
            this.btnInzetten.Name = "btnInzetten";
            this.btnInzetten.Size = new System.Drawing.Size(75, 23);
            this.btnInzetten.TabIndex = 6;
            this.btnInzetten.Text = "Inzetten";
            this.btnInzetten.UseVisualStyleBackColor = true;
            this.btnInzetten.Click += new System.EventHandler(this.btnInzetten_Click);
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(840, 419);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(84, 45);
            this.btnTerug.TabIndex = 7;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbx3
            // 
            this.pbx3.Image = global::ProjectPaardRacing.Properties.Resources.horseEnemy2;
            this.pbx3.Location = new System.Drawing.Point(49, 196);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(100, 60);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 10;
            this.pbx3.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.Image = global::ProjectPaardRacing.Properties.Resources.horseEnemy;
            this.pbx2.Location = new System.Drawing.Point(49, 125);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(100, 65);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 9;
            this.pbx2.TabStop = false;
            // 
            // pbx1
            // 
            this.pbx1.Image = global::ProjectPaardRacing.Properties.Resources.horseUser;
            this.pbx1.Location = new System.Drawing.Point(49, 59);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(100, 59);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 8;
            this.pbx1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectPaardRacing.Properties.Resources.racetrack3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 472);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnInzetten);
            this.Controls.Add(this.lblInzetten);
            this.Controls.Add(this.lblSaldoBedrag);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtInzetten);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRace";
            this.Text = "Paardenrace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRace_FormClosed);
            this.Load += new System.EventHandler(this.frmRace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtInzetten;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoBedrag;
        private System.Windows.Forms.Label lblInzetten;
        private System.Windows.Forms.Button btnInzetten;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Timer timer1;
    }
}