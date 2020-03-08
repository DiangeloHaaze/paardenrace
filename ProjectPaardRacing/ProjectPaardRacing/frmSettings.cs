using System;
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
    public partial class frmSettings : Form
    {
        string naam;
        public frmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            //Bij het laden van settings dat bij gebruikersnaam je naam automatisch tevoorschijn komt.
            txtgebruiker.Text = frminloggen.username;
            kleurwissel(Settings1.Default.backGroundColorS);
        }

        private void Txtgebruiker_TextChanged(object sender, EventArgs e)
        {
            //kijkt of de je de naam hebt aangepast en past deze direct aan. Als je alles verwijdert komt de gebruikersnaam
            // op anoniem te staan en word dit de gebruikersnaam(Diangelo)                
            
                frminloggen.username = txtgebruiker.Text;
        }

        private void Btnterug_Click(object sender, EventArgs e)
        {
            //Knop om terug naar het startscherm te gaan.
            if (frminloggen.username.Equals(""))
            {
                frminloggen.username = "Annoniem";
            }
            frmStartPagina frm = new frmStartPagina();
            frm.Show();
            this.Hide();
        }
        private void kleurwissel(int kleur)
        {
            //Dit zorgt ervoor dat bij het aanpassen van het kleur het juiste kleurtje word gepakt en aangepast
            switch (kleur)
            {
                case 1:
                    this.BackColor = Color.Yellow;
                    Settings1.Default.backGroundColorS = 1;
                    break;
                case 2:
                    this.BackColor = Color.Red;
                    Settings1.Default.backGroundColorS = 2;
                    break;
                case 3:
                    this.BackColor = Color.Blue;
                    Settings1.Default.backGroundColorS = 3;
                    break;
                case 4:
                    this.BackColor = Color.Green;
                    Settings1.Default.backGroundColorS = 4;
                    break;
                case 5:
                    this.BackColor = Color.Gray;
                    Settings1.Default.backGroundColorS = 5;
                    break;
            }
            Settings1.Default.Save();
        }

        private void Rdbgrijs_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(5);
        }

        private void Rdbgeel_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(1);
        }

        private void rdbrood_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(2);
        }

        private void rdbblauw_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(3);
        }

        private void rdbgroen_CheckedChanged(object sender, EventArgs e)
        {
            kleurwissel(4);
        }
        private void Songwissel(int lied)
        {
            switch (lied)
            {
                case 1:
                    Settings1.Default.BackGroundSongS = "Radetzky-Marsch.mp3";
                    break;
                case 2:
                    Settings1.Default.BackGroundSongS = "Vivaldi-Spring.mp3";
                    break;
                case 3:
                    Settings1.Default.BackGroundSongS = "Sibelius-Andante_festivo.mp3";
                    break;
                case 4:
                    Settings1.Default.BackGroundSongS = "geen.mp3";
                    break;
            }
            Settings1.Default.Save();
        }

        private void rdbsong1_CheckedChanged(object sender, EventArgs e)
        {
            Songwissel(1);
        }

        private void gpbmuziek_Enter(object sender, EventArgs e)
        {

        }

        private void rdbsong2_CheckedChanged(object sender, EventArgs e)
        {
            Songwissel(2);
        }

        private void rdbsong3_CheckedChanged(object sender, EventArgs e)
        {
            Songwissel(3);
        }

        private void Btnreset_Click(object sender, EventArgs e)
        {
            Settings1.Default.backGroundColorS = 0;
            Settings1.Default.BackGroundSongS = "geen";
            Settings1.Default.Paard1 = "geen";
            Settings1.Default.Paard2 = "geen";
            Settings1.Default.Paard3 = "geen";
            Settings1.Default.Saldo = 0;
            Settings1.Default.Save();
        }

        private void Rdbgeen_CheckedChanged(object sender, EventArgs e)
        {
            Songwissel(4);
        }
    }
}
