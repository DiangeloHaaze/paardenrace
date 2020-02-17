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
            this.btnbankenrekening = new System.Windows.Forms.Button();
            this.btnOpenmarkt = new System.Windows.Forms.Button();
            this.btnRacebaan = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
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
            // 
            // btnOpenmarkt
            // 
            this.btnOpenmarkt.Location = new System.Drawing.Point(12, 73);
            this.btnOpenmarkt.Name = "btnOpenmarkt";
            this.btnOpenmarkt.Size = new System.Drawing.Size(144, 55);
            this.btnOpenmarkt.TabIndex = 1;
            this.btnOpenmarkt.Text = "Open Markt";
            this.btnOpenmarkt.UseVisualStyleBackColor = true;
            // 
            // btnRacebaan
            // 
            this.btnRacebaan.Location = new System.Drawing.Point(12, 134);
            this.btnRacebaan.Name = "btnRacebaan";
            this.btnRacebaan.Size = new System.Drawing.Size(144, 55);
            this.btnRacebaan.TabIndex = 2;
            this.btnRacebaan.Text = "Racebaan";
            this.btnRacebaan.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 195);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(144, 55);
            this.btnTerug.TabIndex = 3;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // frmGame
            // 
            this.ClientSize = new System.Drawing.Size(567, 276);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnRacebaan);
            this.Controls.Add(this.btnOpenmarkt);
            this.Controls.Add(this.btnbankenrekening);
            this.Name = "frmGame";
            this.Text = "Game";
            this.ResumeLayout(false);

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
    }
}