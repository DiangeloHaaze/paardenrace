﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectPaardRacing
{
    public partial class frminloggen : Form
    {
        //publieke variabele die de gebruikersnaam doorgeeft.
        public static string username, muziek;
        public static int kleur;

        public frminloggen()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            username = txtgebruikersnaam.Text;

            if (string.IsNullOrEmpty(username))
            {
                username = "Annoniem";
            }

            frmStartPagina frmStartPagina = new frmStartPagina();
            frmStartPagina.Show();
            this.Hide();

        }
        private void kleurwissel(int kleur)
        {
            //Dit zorgt ervoor dat bij het aanpassen van het kleur het juiste kleurtje word gepakt en aangepast
            switch (kleur)
            {
                case 1:
                    this.BackColor = Color.Yellow;
                    break;
                case 2:
                    this.BackColor = Color.Red;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    break;
                case 5:
                    this.BackColor = Color.Gray;
                    break;
            }
        }
        private void btnregistratie_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Frminloggen_Load(object sender, EventArgs e)
        {
            kleur = Settings1.Default.backGroundColorS;
            muziek = Settings1.Default.BackGroundSongS;
            kleurwissel(kleur);
        }
       
    }
}//test
