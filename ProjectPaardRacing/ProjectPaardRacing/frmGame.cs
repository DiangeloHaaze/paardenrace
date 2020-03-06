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
        public static int aantalpaarden = Settings1.Default.AantalpaardenS;
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
           //werkt blijkbaar niet meer. Voor dit te kunnen gebruiken moet je in de later voorkomende frmgame_Load1 gebruiken (Diangelo)
        }

        private void Btnbankenrekening_Click(object sender, EventArgs e)
        {
            //Dit is om naar de bank te gaan zodat je geld kan gaan kopen
            frmbank frmbank = new frmbank();
            frmbank.Show();
            this.Hide();
        }

        private void BtnOpenmarkt_Click(object sender, EventArgs e)
        {
            //Knop om naar de Markt te gaan om spullen voor de paarden te gaan kopen
            frmmarkt markt = new frmmarkt();
            markt.Show();
            this.Hide();
        }

        private void BtnRacebaan_Click(object sender, EventArgs e)
        {
            //knop om naar de racebaan te gaan en te gaan racen
            frmRace race = new frmRace();
            race.Show();
            this.Hide();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            //Knop om terug te keren naar startpagina
            frmStartPagina startPagina = new frmStartPagina();
            startPagina.Show();
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

        private void frmGame_Load_1(object sender, EventArgs e)
        {
            kleurwissel(frminloggen.kleur);
        }

        private void btnstallen_Click(object sender, EventArgs e)
        {
            //Om naar de stallen van de paarden toe te gaan
            frmstallen stal = new frmstallen();
            stal.Show();
            this.Hide();
        }

        private void Btnbankenrekening_Click(object sender, EventArgs e)
        {
            frmbank frmbank = new frmbank();
            frmbank.Show();
            this.Hide();
        }

        private void BtnOpenmarkt_Click(object sender, EventArgs e)
        {
            frmmarkt markt = new frmmarkt();
            markt.Show();
            this.Hide();
        }

        private void BtnRacebaan_Click(object sender, EventArgs e)
        {
            frmRace race = new frmRace();
            race.Show();
            this.Hide();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            frmStartPagina startPagina = new frmStartPagina();
            startPagina.Show();
            this.Hide();
        }
    }
}
