namespace ProjectPaardRacing
{
    partial class frminloggen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminloggen));
            this.txtgebruikersnaam = new System.Windows.Forms.TextBox();
            this.lbltitel = new System.Windows.Forms.Label();
            this.lblgebruikersnaam = new System.Windows.Forms.Label();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtgebruikersnaam
            // 
            this.txtgebruikersnaam.Location = new System.Drawing.Point(94, 73);
            this.txtgebruikersnaam.Name = "txtgebruikersnaam";
            this.txtgebruikersnaam.Size = new System.Drawing.Size(119, 20);
            this.txtgebruikersnaam.TabIndex = 0;
            this.txtgebruikersnaam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitel.Location = new System.Drawing.Point(57, 9);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(126, 31);
            this.lbltitel.TabIndex = 1;
            this.lbltitel.Text = "Inloggen";
            // 
            // lblgebruikersnaam
            // 
            this.lblgebruikersnaam.AutoSize = true;
            this.lblgebruikersnaam.Location = new System.Drawing.Point(4, 76);
            this.lblgebruikersnaam.Name = "lblgebruikersnaam";
            this.lblgebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lblgebruikersnaam.TabIndex = 2;
            this.lblgebruikersnaam.Text = "Gebruikersnaam:";
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(63, 134);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(120, 23);
            this.btnInloggen.TabIndex = 3;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggen_Click);
            // 
            // frminloggen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 192);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.lblgebruikersnaam);
            this.Controls.Add(this.lbltitel);
            this.Controls.Add(this.txtgebruikersnaam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frminloggen";
            this.Text = "Inloggen";
            this.Load += new System.EventHandler(this.Frminloggen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgebruikersnaam;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.Label lblgebruikersnaam;
        private System.Windows.Forms.Button btnInloggen;
    }
}

