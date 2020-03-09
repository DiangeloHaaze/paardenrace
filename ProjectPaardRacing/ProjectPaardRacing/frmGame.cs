using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ProjectPaardRacing
{
    public partial class frmGame : Form
    {
        public static String aantalpaarden = Settings1.Default.Paard1;
        public frmGame()
        {
            InitializeComponent();
        }

        private void Btnbankenrekening_Click(object sender, EventArgs e)
        {
            //om naar de bank te kunnen gaan
            frmbank frmbank = new frmbank();
            frmbank.Show();
            this.Hide();
        }

        private void BtnOpenmarkt_Click(object sender, EventArgs e)
        {
            //om naar de markt te kunnen gaan
            frmmarkt markt = new frmmarkt();
            markt.Show();
            this.Hide();
        }

        private void BtnRacebaan_Click(object sender, EventArgs e)
        {
            // Om naar de race te gaan
            frmRace race = new frmRace();
            race.Show();
            this.Hide();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            // Om terug naar de startpagina te gaan
            frmStartPagina startPagina = new frmStartPagina();
            startPagina.Show();
            this.Hide();
        }

        private void FrmGame_Load_1(object sender, EventArgs e)
        {
            kleurwissel(Settings1.Default.backGroundColorS);
            //gebruikersnaam checken & de gevraagde labels te vullen met de corresponderende variabelen
            lblGebruikersnaam.Text = frminloggen.username;
            lblSaldoEuro.Text = Convert.ToString(Settings1.Default.Saldo);
            lblGewonnenAant.Text = Convert.ToString(Settings1.Default.Wins);
            lblVerlorenAant.Text = Convert.ToString(Settings1.Default.Losses);
            int totaal = Settings1.Default.Wins + Settings1.Default.Losses;
            lblWedstrijdenAantal.Text = Convert.ToString(totaal);
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
        private void btnstallen_Click(object sender, EventArgs e)
        {
            //Om naar de stallen te gaan
            frmstal stal = new frmstal();
            stal.Show();
            this.Hide();
        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            // dat bij het closen van de form dat men terug naar de startpagina gaan
            frmStartPagina startPagina = new frmStartPagina();
            startPagina.Show();
            this.Hide();
        }
    }
}
