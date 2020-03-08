namespace ProjectPaardRacing
{
    partial class frmbank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbank));
            this.lblsaldo = new System.Windows.Forms.Label();
            this.lblsaldobedrag = new System.Windows.Forms.Label();
            this.btnterug = new System.Windows.Forms.Button();
            this.btneen = new System.Windows.Forms.Button();
            this.btnvijf = new System.Windows.Forms.Button();
            this.btntien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(47, 28);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(37, 13);
            this.lblsaldo.TabIndex = 0;
            this.lblsaldo.Text = "Saldo:";
            // 
            // lblsaldobedrag
            // 
            this.lblsaldobedrag.AutoSize = true;
            this.lblsaldobedrag.Location = new System.Drawing.Point(90, 28);
            this.lblsaldobedrag.Name = "lblsaldobedrag";
            this.lblsaldobedrag.Size = new System.Drawing.Size(41, 13);
            this.lblsaldobedrag.TabIndex = 1;
            this.lblsaldobedrag.Text = "Bedrag";
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(12, 365);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(119, 73);
            this.btnterug.TabIndex = 2;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // btneen
            // 
            this.btneen.Location = new System.Drawing.Point(12, 61);
            this.btneen.Name = "btneen";
            this.btneen.Size = new System.Drawing.Size(100, 69);
            this.btneen.TabIndex = 3;
            this.btneen.Text = "Leen 100";
            this.btneen.UseVisualStyleBackColor = true;
            this.btneen.Click += new System.EventHandler(this.leeneen_Click);
            // 
            // btnvijf
            // 
            this.btnvijf.Location = new System.Drawing.Point(12, 136);
            this.btnvijf.Name = "btnvijf";
            this.btnvijf.Size = new System.Drawing.Size(100, 69);
            this.btnvijf.TabIndex = 4;
            this.btnvijf.Text = "Leen 500";
            this.btnvijf.UseVisualStyleBackColor = true;
            this.btnvijf.Click += new System.EventHandler(this.btnvijf_Click);
            // 
            // btntien
            // 
            this.btntien.Location = new System.Drawing.Point(12, 211);
            this.btntien.Name = "btntien";
            this.btntien.Size = new System.Drawing.Size(100, 69);
            this.btntien.TabIndex = 5;
            this.btntien.Text = "Leen 1000";
            this.btntien.UseVisualStyleBackColor = true;
            this.btntien.Click += new System.EventHandler(this.btntien_Click);
            // 
            // frmbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 447);
            this.Controls.Add(this.btntien);
            this.Controls.Add(this.btnvijf);
            this.Controls.Add(this.btneen);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.lblsaldobedrag);
            this.Controls.Add(this.lblsaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmbank";
            this.Text = "bank";
            this.Load += new System.EventHandler(this.frmbank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label lblsaldobedrag;
        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.Button btneen;
        private System.Windows.Forms.Button btnvijf;
        private System.Windows.Forms.Button btntien;
    }
}