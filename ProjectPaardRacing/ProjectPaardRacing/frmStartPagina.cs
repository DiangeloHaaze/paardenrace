using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace ProjectPaardRacing
{
    public partial class frmStartPagina : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public frmStartPagina()
        {
            InitializeComponent();
            if (!(Settings1.Default.BackGroundSongS.Equals("geen")))
            {
                player.URL = Settings1.Default.BackGroundSongS;
            }
            
        }

        private void frmStartPagina_Load(object sender, EventArgs e)
        {
            //Nadat je succesvol bent ingelogd word je hier doorverwezen en word je welkom geheten. Dit is nog in een simplistische vorm en is niet 
            // compleet representatief met het gewenste product (Diangelo)
            frminloggen inloggen = new frminloggen();

            string gebruiker = frminloggen.username;
            lblstarttitel.Text = "Welkom " + gebruiker;
            kleurwissel(Settings1.Default.backGroundColorS);
            player.controls.play();
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            player.controls.stop();
        }

        private void btnstartspel_Click(object sender, EventArgs e)
        {
            // Om naar de game form te gaan
            frmGame fromgame = new frmGame();

            fromgame.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            // Om naarde settingsform te gaan
            frmSettings formset = new frmSettings();
            formset.Show();
            this.Hide();
            player.controls.stop();
        }
    }
}
