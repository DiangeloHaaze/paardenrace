namespace ProjectPaardRacing
{
    partial class frmstal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstal));
            this.lblstaleen = new System.Windows.Forms.Label();
            this.lblstaltwee = new System.Windows.Forms.Label();
            this.lblstaldrie = new System.Windows.Forms.Label();
            this.btnterug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstaleen
            // 
            this.lblstaleen.AutoSize = true;
            this.lblstaleen.Location = new System.Drawing.Point(26, 43);
            this.lblstaleen.Name = "lblstaleen";
            this.lblstaleen.Size = new System.Drawing.Size(31, 13);
            this.lblstaleen.TabIndex = 0;
            this.lblstaleen.Text = "Stal1";
            this.lblstaleen.Click += new System.EventHandler(this.lblstaleen_Click);
            // 
            // lblstaltwee
            // 
            this.lblstaltwee.AutoSize = true;
            this.lblstaltwee.Location = new System.Drawing.Point(75, 43);
            this.lblstaltwee.Name = "lblstaltwee";
            this.lblstaltwee.Size = new System.Drawing.Size(31, 13);
            this.lblstaltwee.TabIndex = 1;
            this.lblstaltwee.Text = "Stal1";
            // 
            // lblstaldrie
            // 
            this.lblstaldrie.AutoSize = true;
            this.lblstaldrie.Location = new System.Drawing.Point(133, 43);
            this.lblstaldrie.Name = "lblstaldrie";
            this.lblstaldrie.Size = new System.Drawing.Size(31, 13);
            this.lblstaldrie.TabIndex = 2;
            this.lblstaldrie.Text = "Stal1";
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(12, 374);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(109, 64);
            this.btnterug.TabIndex = 3;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // frmstal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.lblstaldrie);
            this.Controls.Add(this.lblstaltwee);
            this.Controls.Add(this.lblstaleen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmstal";
            this.Text = "Stallen";
            this.Load += new System.EventHandler(this.frmstal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstaleen;
        private System.Windows.Forms.Label lblstaltwee;
        private System.Windows.Forms.Label lblstaldrie;
        private System.Windows.Forms.Button btnterug;
    }
}