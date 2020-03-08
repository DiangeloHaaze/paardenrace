namespace ProjectPaardRacing
{
    partial class frmStartPagina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartPagina));
            this.btnstartspel = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblstarttitel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnstartspel
            // 
            this.btnstartspel.Location = new System.Drawing.Point(143, 96);
            this.btnstartspel.Name = "btnstartspel";
            this.btnstartspel.Size = new System.Drawing.Size(169, 49);
            this.btnstartspel.TabIndex = 0;
            this.btnstartspel.Text = "Start Spel";
            this.btnstartspel.UseVisualStyleBackColor = true;
            this.btnstartspel.Click += new System.EventHandler(this.btnstartspel_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.Location = new System.Drawing.Point(143, 168);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(169, 49);
            this.btnsettings.TabIndex = 1;
            this.btnsettings.Text = "Settings";
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(143, 245);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(169, 49);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblstarttitel
            // 
            this.lblstarttitel.AutoSize = true;
            this.lblstarttitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstarttitel.Location = new System.Drawing.Point(113, 38);
            this.lblstarttitel.Name = "lblstarttitel";
            this.lblstarttitel.Size = new System.Drawing.Size(183, 31);
            this.lblstarttitel.TabIndex = 3;
            this.lblstarttitel.Text = "Start Pagina ";
            // 
            // frmStartPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 364);
            this.Controls.Add(this.lblstarttitel);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnstartspel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStartPagina";
            this.Text = "Start Pagina";
            this.Load += new System.EventHandler(this.frmStartPagina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnstartspel;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblstarttitel;
    }
}