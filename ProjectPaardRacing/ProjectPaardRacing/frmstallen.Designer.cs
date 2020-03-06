namespace ProjectPaardRacing
{
    partial class frmstallen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstallen));
            this.pcbstal1 = new System.Windows.Forms.PictureBox();
            this.pcbstal2 = new System.Windows.Forms.PictureBox();
            this.pcbstal3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal3)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbstal1
            // 
            this.pcbstal1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbstal1.Location = new System.Drawing.Point(36, 30);
            this.pcbstal1.Name = "pcbstal1";
            this.pcbstal1.Size = new System.Drawing.Size(198, 189);
            this.pcbstal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbstal1.TabIndex = 0;
            this.pcbstal1.TabStop = false;
            this.pcbstal1.Click += new System.EventHandler(this.pcbstal1_Click);
            // 
            // pcbstal2
            // 
            this.pcbstal2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbstal2.Location = new System.Drawing.Point(280, 30);
            this.pcbstal2.Name = "pcbstal2";
            this.pcbstal2.Size = new System.Drawing.Size(198, 189);
            this.pcbstal2.TabIndex = 1;
            this.pcbstal2.TabStop = false;
            // 
            // pcbstal3
            // 
            this.pcbstal3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pcbstal3.Location = new System.Drawing.Point(518, 30);
            this.pcbstal3.Name = "pcbstal3";
            this.pcbstal3.Size = new System.Drawing.Size(198, 189);
            this.pcbstal3.TabIndex = 2;
            this.pcbstal3.TabStop = false;
            this.pcbstal3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmstallen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcbstal3);
            this.Controls.Add(this.pcbstal2);
            this.Controls.Add(this.pcbstal1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmstallen";
            this.Text = "frmstallen";
            this.Load += new System.EventHandler(this.frmstallen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbstal3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbstal1;
        private System.Windows.Forms.PictureBox pcbstal2;
        private System.Windows.Forms.PictureBox pcbstal3;
    }
}