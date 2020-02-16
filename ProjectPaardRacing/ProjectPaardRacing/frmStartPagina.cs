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
    public partial class frmStartPagina : Form
    {
        public frmStartPagina()
        {
            InitializeComponent();
        }

        private void frmStartPagina_Load(object sender, EventArgs e)
        {
            //Nadat je succesvol bent ingelogd word je hier doorverwezen en word je welkom geheten. Dit is nog in een simplistische vorm en is niet 
            // compleet representatief met het gewenste product (Diangelo)
            frminloggen frminloggen = new frminloggen();

            string gebruiker = frminloggen.username;

            lblstarttitel.Text = "Welkom " + gebruiker;
         }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnstartspel_Click(object sender, EventArgs e)
        {
            // Om naarde game form te gaan
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
        }
    }
}
