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
            this.grpBoxKeuze = new System.Windows.Forms.GroupBox();
            this.rdbPaard3 = new System.Windows.Forms.RadioButton();
            this.rdbPaard2 = new System.Windows.Forms.RadioButton();
            this.rdbPaard1 = new System.Windows.Forms.RadioButton();
            this.grpBoxKeuze.SuspendLayout();
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
            this.btnterug.Location = new System.Drawing.Point(12, 428);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(109, 64);
            this.btnterug.TabIndex = 3;
            this.btnterug.Text = "Terug";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // grpBoxKeuze
            // 
            this.grpBoxKeuze.Controls.Add(this.rdbPaard3);
            this.grpBoxKeuze.Controls.Add(this.rdbPaard2);
            this.grpBoxKeuze.Controls.Add(this.rdbPaard1);
            this.grpBoxKeuze.Location = new System.Drawing.Point(136, 400);
            this.grpBoxKeuze.Name = "grpBoxKeuze";
            this.grpBoxKeuze.Size = new System.Drawing.Size(88, 92);
            this.grpBoxKeuze.TabIndex = 4;
            this.grpBoxKeuze.TabStop = false;
            this.grpBoxKeuze.Text = "Paard kiezen";
            this.grpBoxKeuze.Enter += new System.EventHandler(this.grpBoxKeuze_Enter);
            // 
            // rdbPaard3
            // 
            this.rdbPaard3.AutoSize = true;
            this.rdbPaard3.Location = new System.Drawing.Point(28, 64);
            this.rdbPaard3.Name = "rdbPaard3";
            this.rdbPaard3.Size = new System.Drawing.Size(50, 17);
            this.rdbPaard3.TabIndex = 2;
            this.rdbPaard3.TabStop = true;
            this.rdbPaard3.Text = "stal 3";
            this.rdbPaard3.UseVisualStyleBackColor = true;
            this.rdbPaard3.CheckedChanged += new System.EventHandler(this.rdbPaard3_CheckedChanged);
            // 
            // rdbPaard2
            // 
            this.rdbPaard2.AutoSize = true;
            this.rdbPaard2.Location = new System.Drawing.Point(28, 42);
            this.rdbPaard2.Name = "rdbPaard2";
            this.rdbPaard2.Size = new System.Drawing.Size(50, 17);
            this.rdbPaard2.TabIndex = 1;
            this.rdbPaard2.TabStop = true;
            this.rdbPaard2.Text = "stal 2";
            this.rdbPaard2.UseVisualStyleBackColor = true;
            this.rdbPaard2.CheckedChanged += new System.EventHandler(this.rdbPaard2_CheckedChanged);
            // 
            // rdbPaard1
            // 
            this.rdbPaard1.AutoSize = true;
            this.rdbPaard1.Location = new System.Drawing.Point(28, 19);
            this.rdbPaard1.Name = "rdbPaard1";
            this.rdbPaard1.Size = new System.Drawing.Size(50, 17);
            this.rdbPaard1.TabIndex = 0;
            this.rdbPaard1.TabStop = true;
            this.rdbPaard1.Text = "stal 1";
            this.rdbPaard1.UseVisualStyleBackColor = true;
            this.rdbPaard1.CheckedChanged += new System.EventHandler(this.rdbPaard1_CheckedChanged);
            // 
            // frmstal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.grpBoxKeuze);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.lblstaldrie);
            this.Controls.Add(this.lblstaltwee);
            this.Controls.Add(this.lblstaleen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmstal";
            this.Text = "Stallen";
            this.Load += new System.EventHandler(this.frmstal_Load);
            this.grpBoxKeuze.ResumeLayout(false);
            this.grpBoxKeuze.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstaleen;
        private System.Windows.Forms.Label lblstaltwee;
        private System.Windows.Forms.Label lblstaldrie;
        private System.Windows.Forms.Button btnterug;
        private System.Windows.Forms.GroupBox grpBoxKeuze;
        private System.Windows.Forms.RadioButton rdbPaard3;
        private System.Windows.Forms.RadioButton rdbPaard2;
        private System.Windows.Forms.RadioButton rdbPaard1;
    }
}